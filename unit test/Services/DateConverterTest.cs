using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DateConverter.Core.Library;
using Moq;
using DateConverter.Core.Rough_Library;
using DateConverter.Core;

namespace unit_test.Services
{
    [TestClass]
    public class DateConverterTest
    {
        iDateConverter dc;
        YearsIntervalDateConverter original;
        [TestInitialize]
        public void setup()
        {
            dc = DateConverter.Core.Service_Factory.DateConverterFactory.getDateConverterService();
            original = new YearsIntervalDateConverter();
        }

        [TestMethod]
        public void testEnglishToNepaliConverter()
        {
            DateTime testDate = new DateTime(1944, 03, 01);
            while (testDate < new DateTime(2034, 01, 01))
            {
                Assert.AreEqual(dc.ToBS(testDate).getFormattedDate(), original.ToBS(testDate));
                testDate = testDate.AddDays(100);
            }
        }

        [TestMethod]
        public void testNepaliToEnglishConverter()
        {
            string mm = "02";
            int yyyy = 2000;
            string dd = "20";
            DateTime testDate = new DateTime(1944, 03, 01);
            while (yyyy < 2090)
            {
                string date = mm + "/" + dd + "/" + yyyy;
                Assert.AreEqual(dc.ToAD(date).getFormattedDate(), original.ToAD(date));
                yyyy += 1;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testExceptionInInvalidNepaliDateToAD()
        {
            dc.ToAD("10/30/2007");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void testExceptionWhenMonthExceeds12ToAD()
        {
            dc.ToAD("13/30/2007");
        }

        [TestMethod]
        public void testDayNameFromConvertedDateToBS()
        {
            NepaliDate nepali_date = new NepaliDate();
            nepali_date = dc.ToBS(new DateTime(2018, 03, 06));
            Assert.AreEqual("tuesday", nepali_date.dayName.ToLower());
            nepali_date = dc.ToBS(new DateTime(2000, 01, 04));
            Assert.AreEqual("tuesday", nepali_date.dayName.ToLower());

            nepali_date = dc.ToBS(new DateTime(1946, 12, 16));
            Assert.AreEqual("monday", nepali_date.dayName.ToLower());

            nepali_date = dc.ToBS(new DateTime(1996, 08, 15));
            Assert.AreEqual("thursday", nepali_date.dayName.ToLower());

            nepali_date = dc.ToBS(new DateTime(1973, 08, 15));
            Assert.AreEqual("wednesday", nepali_date.dayName.ToLower());

            nepali_date = dc.ToBS(new DateTime(1980, 08, 15));
            Assert.AreEqual("friday", nepali_date.dayName.ToLower());
        }

        [TestMethod]
        public void testDayNumberFromConvertedDateToBS()
        {
            NepaliDate nepali_date = new NepaliDate();

            nepali_date = dc.ToBS(new DateTime(2018, 03, 03));
            Assert.AreEqual(7, nepali_date.dayNumber);

            nepali_date = dc.ToBS(new DateTime(2018, 03, 06));
            Assert.AreEqual(3, nepali_date.dayNumber);

            nepali_date = dc.ToBS(new DateTime(2000, 01, 04));
            Assert.AreEqual(3, nepali_date.dayNumber);

            nepali_date = dc.ToBS(new DateTime(1946, 12, 16));
            Assert.AreEqual(2, nepali_date.dayNumber);

            nepali_date = dc.ToBS(new DateTime(1996, 08, 15));
            Assert.AreEqual(5, nepali_date.dayNumber);

            nepali_date = dc.ToBS(new DateTime(1973, 08, 15));
            Assert.AreEqual(4, nepali_date.dayNumber);

            nepali_date = dc.ToBS(new DateTime(1980, 08, 15));
            Assert.AreEqual(6, nepali_date.dayNumber);



        }

        [TestMethod]
        public void testDayNumberFromConvertedDateToAD()
        {
            EnglishDate english_date = new EnglishDate();

            string nep_date = "11/10/2070";
            Assert.AreEqual(7, dc.ToAD(nep_date).dayNumber);

            nep_date = "01/01/2013";
            Assert.AreEqual(6, dc.ToAD(nep_date).dayNumber);

            nep_date = "12/10/2000";
            Assert.AreEqual(4, dc.ToAD(nep_date).dayNumber);
        }

        [TestMethod]
        public void testDayNameFromConvertedDateToAD1()
        {
            EnglishDate english_date = new EnglishDate();

            string nep_date = "11/10/2070";
            Assert.AreEqual("saturday", dc.ToAD(nep_date).dayName.ToLower());

            nep_date = "01/01/2013";
            Assert.AreEqual("friday", dc.ToAD(nep_date).dayName.ToLower());

            nep_date = "12/10/2000";
            Assert.AreEqual("wednesday", dc.ToAD(nep_date).dayName.ToLower());
        }

        [TestMethod]
        public void testNepaliYear2122IsValidRangeDuringConversion()
        {
            EnglishDate english_date = new EnglishDate();

            string nep_date = "11/10/2121";
            dc.ToAD(nep_date);
        }
    }
}
