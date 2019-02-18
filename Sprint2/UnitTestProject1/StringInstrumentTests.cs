using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint2;

namespace InstrumentTests
{
    [TestClass]
    public class StringInstrumentTests: InstrumentTests
    {
        StringInstrument s;

        [TestMethod]
        public override void TestConstructor()
        {
            s = new StringInstrument();

            Assert.AreEqual("Wood", s.Material);
        }

        [TestMethod]
        public override void TestAbout()
        {
            s = new StringInstrument();

            base.TestAbout();
            Assert.AreEqual(s + $" has {s.NumberOfStrings} strings", s.About());
        }
    }
}
