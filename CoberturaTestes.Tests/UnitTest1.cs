using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoberturaTestes.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Usuario usuario = new Usuario();

            var teste = usuario.CriarUsuario();

            var result = string.IsNullOrEmpty(teste);

            Assert.IsFalse(result);
        }
    }
}
