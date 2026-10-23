using Dominio.Validaciones;

namespace Test
{
    [TestClass]
    public sealed class ValidadorTest
    {
        [TestMethod]
        [DataRow("juan@mail.com")]
        [DataRow("juan.perez+tpi@ifts.edu.ar")]
        public void Given_EmailBienFormado_When_EsEmail_Then_DevuelveTrue(string email)
        {
            Assert.IsTrue(Validador.EsEmail(email));
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("juan")]
        [DataRow("juan@mail")]
        [DataRow("juan @mail.com")]
        [DataRow(null)]
        public void Given_EmailMalFormado_When_EsEmail_Then_DevuelveFalse(string? email)
        {
            Assert.IsFalse(Validador.EsEmail(email));
        }

        [TestMethod]
        [DataRow("1145678901")]
        [DataRow("11 4567-8901")]
        [DataRow("+54 9 11 4567 8901")]
        [DataRow("221 456-7890")]
        public void Given_TelefonoValido_When_EsTelefono_Then_DevuelveTrue(string telefono)
        {
            Assert.IsTrue(Validador.EsTelefono(telefono));
        }

        [TestMethod]
        [DataRow("123")]
        [DataRow("11-abcd-8901")]
        [DataRow("")]
        public void Given_TelefonoInvalido_When_EsTelefono_Then_DevuelveFalse(string telefono)
        {
            Assert.IsFalse(Validador.EsTelefono(telefono));
        }

        [TestMethod]
        [DataRow("12345678")]
        [DataRow("12.345.678")]
        [DataRow("1.234.567")]
        public void Given_DniValido_When_EsDni_Then_DevuelveTrue(string dni)
        {
            Assert.IsTrue(Validador.EsDni(dni));
        }

        [TestMethod]
        [DataRow("123456")]
        [DataRow("123456789")]
        [DataRow("12-345-678")]
        [DataRow("")]
        public void Given_DniInvalido_When_EsDni_Then_DevuelveFalse(string dni)
        {
            Assert.IsFalse(Validador.EsDni(dni));
        }
    }
}
