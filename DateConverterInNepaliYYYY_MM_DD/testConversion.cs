using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DateConverter.Core.Rough_Library;

namespace DateConverterInNepaliYYYY_MM_DD
{
    [TestClass]
    public class testConversion
    {
        DateConverter testDateConverter = new DateConverter();
        YearsIntervalDateConverter originalConverter = new YearsIntervalDateConverter();
        [TestInitialize]
        public void setup()
        {

        }

        [TestMethod]
        public void testToAD()
        {
            int year = 2000;
            int month = 01;
            int day = 20;
            while (year < 2090)
            {
                Assert.AreEqual(testDateConverter.ToAD(year + "/" + month + "/" + day), originalConverter.ToAD(month + "/" + day + "/" + year));
                year++;
            }
            
        }

        [TestMethod]
        public void testToBS()
        {
            DateTime testDate = new DateTime(1944, 03, 01);
            while (testDate < new DateTime(2034, 01, 01))
            {
                string nep_test_date = testDateConverter.ToBS(testDate);
                string nep_original_date = originalConverter.ToBS(testDate);
                System.String[] testDateParts = nep_test_date.Split(new[] { "/" }, System.StringSplitOptions.None);
                int test_yy = int.Parse(testDateParts[0]);
                int test_mm = int.Parse(testDateParts[1]);
                int test_dd = int.Parse(testDateParts[2]);

                System.String[] originalDateParts = nep_original_date.Split(new[] { "-" }, System.StringSplitOptions.None);
                int original_mm = int.Parse(originalDateParts[0]);
                int original_dd = int.Parse(originalDateParts[1]);
                int original_yy = int.Parse(originalDateParts[2]);

                Assert.AreEqual(test_yy, original_yy);
                Assert.AreEqual(test_mm, original_mm);
                Assert.AreEqual(test_dd, original_dd);
                testDate = testDate.AddDays(23);
            }
        }
    }
}
