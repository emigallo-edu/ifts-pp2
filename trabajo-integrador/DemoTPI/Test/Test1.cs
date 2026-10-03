using DemoTPI.Entidades;
using DemoTPI.Services;

namespace Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Given_NoEstudiantesEnRepositorio_When_ObtenerEstudiantes_Then_LanzaExcepcion()
        {
            // Software Under Development
            ObtenerEstudiantesService sut = new ObtenerEstudiantesService(new EstudianteRepositorioFake());

            try
            {
                var estudiantes = sut.ObtenerEstudiantes();
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("No se encontraron estudiantes", ex.Message);
            }
        }
    }
}
