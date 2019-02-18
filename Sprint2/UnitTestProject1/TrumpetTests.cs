using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint2;

namespace InstrumentTests
{
    [TestClass]
    public class TrumpetTests : HornTests
    {
        [TestMethod]
        public override void TestConstructor()
        {
            Trumpet t = new Trumpet();

            Assert.AreEqual("Toot", t.Sound);
        }
    }
}
