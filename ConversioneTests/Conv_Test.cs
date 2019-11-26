using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversioniLibreria;

namespace ConversioneTests
{
    [TestClass]
    public class TestConversione
    {
        [TestMethod]
        public void Example1Test()
        {
            bool r = Conv.Example1();
            Assert.AreEqual(true, r);
        }
        [TestMethod]
        public void Example2Test()
        {
            bool r = Conv.Example2();
            Assert.AreEqual(true, r);
        }
    }
}
