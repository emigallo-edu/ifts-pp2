using Dominio.Entidades;
using Dominio.Services;

namespace Test
{
    [TestClass]
    public sealed class RegistrarEstudianteServiceTest
    {
        private static Estudiante EstudianteValido()
        {
            return new Estudiante()
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                Email = "juan@mail.com",
                Telefono = "11 4567-8901",
                Dni = "12.345.678"
            };
        }

        [TestMethod]
        public void Given_EstudianteValido_When_Registrar_Then_SeGuardaConDniSinPuntos()
        {
            EstudianteRepositorioFake repositorio = new EstudianteRepositorioFake();
            RegistrarEstudianteService sut = new RegistrarEstudianteService(repositorio);

            sut.Registrar(EstudianteValido());

            List<Estudiante> guardados = repositorio.ObtenerTodos();
            Assert.HasCount(1, guardados);
            Assert.AreEqual("12345678", guardados[0].Dni);
        }

        [TestMethod]
        public void Given_EmailInvalido_When_Registrar_Then_LanzaExcepcionYNoGuarda()
        {
            EstudianteRepositorioFake repositorio = new EstudianteRepositorioFake();
            RegistrarEstudianteService sut = new RegistrarEstudianteService(repositorio);
            Estudiante estudiante = EstudianteValido();
            estudiante.Email = "juan@mail";

            ArgumentException ex = Assert.ThrowsExactly<ArgumentException>(() => sut.Registrar(estudiante));

            Assert.AreEqual("El email no es válido", ex.Message);
            Assert.IsEmpty(repositorio.ObtenerTodos());
        }

        [TestMethod]
        public void Given_DniInvalido_When_Registrar_Then_LanzaExcepcion()
        {
            RegistrarEstudianteService sut = new RegistrarEstudianteService(new EstudianteRepositorioFake());
            Estudiante estudiante = EstudianteValido();
            estudiante.Dni = "123";

            ArgumentException ex = Assert.ThrowsExactly<ArgumentException>(() => sut.Registrar(estudiante));

            Assert.AreEqual("El DNI no es válido", ex.Message);
        }
    }
}
