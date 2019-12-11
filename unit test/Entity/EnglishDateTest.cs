using DateConverter.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace unit_test.Entity
{
    [TestClass]
    public class EnglishDateTest
    {
        EnglishDate englishDate;
        [TestInitialize]
        public void setup()
        {
            englishDate = new EnglishDate();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testMonthCannotBeGreaterThan12()
        {
            englishDate.engMonth = 13;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testDayCannotBeGreaterThan31()
        {
            englishDate.engDay = 32;
        }

       
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testExceptionIfEngishDateComponentsAreNotSetBeforeRetrieving()
        {
            englishDate.getFormattedDate();
        }
    }
}
