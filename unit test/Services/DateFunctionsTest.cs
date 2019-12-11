using DateConverter.Core.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace unit_test.Services
{
    [TestClass]
    public class DateFunctionsTest
    {
        iDateFunctions dateFunctions;
        [TestInitialize]
        public void setup()
        {
            dateFunctions = DateConverter.Core.Service_Factory.DateFunctionsFactory.getDateFunctionsService();
        }

        [TestMethod]
        public void testLeapYear()
        {
            Assert.IsTrue(dateFunctions.IsLeapYear(2000));
        }

        [TestMethod]
        public void testNotALeapYear()
        {
            Assert.IsFalse(dateFunctions.IsLeapYear(2001));
        }

        [TestMethod]
        public void testEnglishMonthNameAgainstIntValues()
        {
            for (int i = 1; i <= 12; i++)
            {
                string monthName = new DateTime(2010, i, 1)
     .ToString("MMMMMMMMMMMMMMMMMM", CultureInfo.InvariantCulture);
                Assert.AreEqual(monthName.ToLower().Trim(), dateFunctions.GetEnglishMonth(i).ToLower().Trim());
            }
        }

        [TestMethod]
        public void testEnglishDayNameAgainstIntValues()
        {
            for(int i = 1; i <= 7; i++)
            {
                //in english first day is monday, so minus 1
                string dayName = (Enum.GetName(typeof(DayOfWeek), i-1)).ToLower().ToString();
                Assert.AreEqual(dayName, dateFunctions.GetDayOfWeek(i).ToLower().Trim());
            }
        }
    }
}
