using DateConverter.Core.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace unit_test.Services
{
    [TestClass]
    public class FiscalYearTest
    {
        iFiscalYearFunctions fiscalYearFunctions;
        [TestInitialize]
        public void setup()
        {
            fiscalYearFunctions = DateConverter.Core.Service_Factory.FiscalYearFactory.getFiscalYearService();
        }

        [TestMethod]
        public void testNepaliFiscalYearForGivenEnglishDate()
        {
            Assert.AreEqual(2074, fiscalYearFunctions.getFiscalYear(new DateTime(2018, 01, 02)));
        }

        [TestMethod]
        public void testStartingDateOfNepaliFiscalYearIsFirstOfShrawan()
        {
            Assert.AreEqual(new DateTime(2074,04,01), fiscalYearFunctions.getStartDateOfFiscalYear(2074));
        }

        [TestMethod]
        public void testEndDateOfNepaliFiscalYearIsFirstOfShrawanOfNextYear()
        {
            Assert.AreEqual("03-32-2075", fiscalYearFunctions.getLastDateOfFiscalYear(2074));
        }
    }
}
