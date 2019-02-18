using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint2;

namespace InstrumentTests
{
    [TestClass]
    public class GuitarTests : StringInstrumentTests
    {
        [TestMethod]
        public override void TestConstructor()
        {
            Guitar g = new Guitar();

            Assert.AreEqual(6, g.NumberOfStrings);
            Assert.AreEqual("Strum", g.Sound);
        }
    }
}
