using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint2;

namespace InstrumentTests
{
    [TestClass]
    public class UkuleleTests : StringInstrumentTests
    {
        [TestMethod]
        public override void TestConstructor()
        {
            Ukulele u = new Ukulele();

            Assert.AreEqual(4, u.NumberOfStrings);
            Assert.AreEqual("Small Strum", u.Sound);
        }
    }
}
