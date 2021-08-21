using DateConverter.Core;
using DateConverter.Core.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace unit_test.Entity
{
    [TestClass]
    public class NepaliDateTest
    {
        NepaliDate nepaliDate;
        [TestInitialize]
        public void setup()
        {
            nepaliDate = new NepaliDate();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testMonthCannotBeGreaterThan12()
        {
            nepaliDate.npMonth = 13;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testDayCannotBeGreaterThan32()
        {
            nepaliDate.npDay = 33;
        }

        [TestMethod]
        public void testFormattedNepaliDateInMDYFormat()
        {
            nepaliDate.setFormattedDate(2074, 01, 25, DateFormats.mDy);
            Assert.AreEqual("01-25-2074", nepaliDate.getFormattedDate());
        }

        [TestMethod]
        public void testFormattedNepaliDateInDMYFormat()
        {
            nepaliDate.setFormattedDate(2074, 01, 25, DateFormats.dMy);
            Assert.AreEqual("25-01-2074", nepaliDate.getFormattedDate());
        }

        [TestMethod]
        public void testFormattedNepaliDateInYMDFormat()
        {
            nepaliDate.setFormattedDate(2074, 01, 25, DateFormats.yMd);
            Assert.AreEqual("2074-01-25", nepaliDate.getFormattedDate());
        }
    }
}
