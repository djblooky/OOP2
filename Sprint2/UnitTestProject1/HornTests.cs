using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint2;

namespace InstrumentTests
{
    [TestClass]
    public class HornTests : InstrumentTests
    {
        [TestMethod]
        public override void TestConstructor()
        {
            Horn h = new Horn();

            Assert.AreEqual("Brass", h.Material);
        }
    }
}
