using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(ConsoleApp.Program.Main(1), 321);
            Assert.AreEqual(ConsoleApp.Program.Main(2), 765);
            Assert.AreEqual(ConsoleApp.Program.Main(3), 123);

        }
    }
}