using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialAlejandroSivila;
using ParcialAlejandroSivila.Controllers;

namespace Testparcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            PaisController controller = new PaisController();
            //act
            var listapaises = controller.GetPais();
        }
    }
}
