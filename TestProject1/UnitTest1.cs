using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(ConsoleApp.Program.Volume(4,3), 64);
            Assert.AreEqual(ConsoleApp.Program.Surface(4,2,6), 96);
        }
    }
}