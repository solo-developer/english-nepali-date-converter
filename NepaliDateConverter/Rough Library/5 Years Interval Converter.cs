/*
Instead of iterating from begining , start iterating between 5 years interval.so that, performance is optimised around 10 times
 */


using System;

namespace DateConverter.Core.Rough_Library
{

    public class YearsIntervalDateConverter
    {
        private System.DateTime _Date;

        public YearsIntervalDateConverter()
        {
            this._Date = DateTime.Now;
        }

        public YearsIntervalDateConverter(System.DateTime givenDate)
        {
            this._Date = givenDate;
        }

        // function get the last day of the fiscal_year
        public string getLastDateOfFiscalYear(int fiscal_year)
        {
            if ((fiscal_year < 1000))
            {
                return "";
            }
            return new System.DateTime(fiscal_year + 1, 3, this.getLastDayOfMonthNep(fiscal_year + 1, 3)).ToShortDateString();
        }

        public int getFiscalYear(System.DateTime givenDate)
        {
            // first find year
            if ((givenDate == null))
            {
                givenDate = DateTime.Now;
            }
            YearsIntervalDateConverter DC = new YearsIntervalDateConverter(givenDate);
            string dt = DC.ToBS(givenDate);

            System.String[] userDateParts = dt.Split(new[] { "-" }, System.StringSplitOptions.None);
            int Month = int.Parse(userDateParts[0]);
            int Day = int.Parse(userDateParts[1]);
            int Year = int.Parse(userDateParts[2]);

            int first = int.Parse(userDateParts[2]);
            int second = int.Parse(userDateParts[2]);
            if ((Month >= 4))
            {
                return Year;
            }
            else
            {
                return Year - 1;
            }

        }

        public System.DateTime getStartDateOfFiscalYear(int fiscal_year)
        {
            return new System.DateTime(fiscal_year, 4, 1);
        }


        public int getLastDayOfMonthNep(int year, int month)
        {
            int[][] bs = null;
            bs = new int[91][];
            if ((year > 1999))
            {
                year = year - 2000;
            }
            //The following data allows the coversion between the range 1944-2033 (AD) only

            bs[0] = new int[]{
            2000,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[1] = new int[]{
            2001,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[2] = new int[]{
            2002,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[3] = new int[]{
            2003,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[4] = new int[]{
            2004,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[5] = new int[]{
            2005,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[6] = new int[]{
            2006,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[7] = new int[]{
            2007,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[8] = new int[]{
            2008,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            29,
            31
        };

            bs[9] = new int[]{
            2009,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[10] = new int[]{
            2010,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[11] = new int[]{
            2011,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[12] = new int[]{
            2012,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[13] = new int[]{
            2013,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[14] = new int[]{
            2014,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[15] = new int[]{
            2015,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[16] = new int[]{
            2016,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[17] = new int[]{
            2017,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[18] = new int[]{
            2018,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[19] = new int[]{
            2019,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[20] = new int[]{
            2020,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[21] = new int[]{
            2021,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[22] = new int[]{
            2022,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[23] = new int[]{
            2023,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[24] = new int[]{
            2024,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[25] = new int[]{
            2025,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[26] = new int[]{
            2026,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[27] = new int[]{
            2027,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[28] = new int[]{
            2028,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[29] = new int[]{
            2029,
            31,
            31,
            32,
            31,
            32,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[30] = new int[]{
            2030,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[31] = new int[]{
            2031,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[32] = new int[]{
            2032,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[33] = new int[]{
            2033,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[34] = new int[]{
            2034,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[35] = new int[]{
            2035,
            30,
            32,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            29,
            31
        };

            bs[36] = new int[]{
            2036,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[37] = new int[]{
            2037,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[38] = new int[]{
            2038,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[39] = new int[]{
            2039,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[40] = new int[]{
            2040,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[41] = new int[]{
            2041,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[42] = new int[]{
            2042,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[43] = new int[]{
            2043,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[44] = new int[]{
            2044,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[45] = new int[]{
            2045,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[46] = new int[]{
            2046,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[47] = new int[]{
            2047,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[48] = new int[]{
            2048,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[49] = new int[]{
            2049,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[50] = new int[]{
            2050,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[51] = new int[]{
            2051,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[52] = new int[]{
            2052,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[53] = new int[]{
            2053,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[54] = new int[]{
            2054,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[55] = new int[]{
            2055,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[56] = new int[]{
            2056,
            31,
            31,
            32,
            31,
            32,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[57] = new int[]{
            2057,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[58] = new int[]{
            2058,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[59] = new int[]{
            2059,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[60] = new int[]{
            2060,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[61] = new int[]{
            2061,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[62] = new int[]{
            2062,
            30,
            32,
            31,
            32,
            31,
            31,
            29,
            30,
            29,
            30,
            29,
            31
        };

            bs[63] = new int[]{
            2063,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[64] = new int[]{
            2064,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[65] = new int[]{
            2065,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[66] = new int[]{
            2066,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            29,
            31
        };

            bs[67] = new int[]{
            2067,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[68] = new int[]{
            2068,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[69] = new int[]{
            2069,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[70] = new int[]{
            2070,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[71] = new int[]{
            2071,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[72] = new int[]{
            2072,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[73] = new int[]{
            2073,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[74] = new int[]{
            2074,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[75] = new int[]{
            2075,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[76] = new int[]{
            2076,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[77] = new int[]{
            2077,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[78] = new int[]{
            2078,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[79] = new int[]{
            2079,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[80] = new int[]{
            2080,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[81] = new int[]{
            2081,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[82] = new int[]{
            2082,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[83] = new int[]{
            2083,
            31,
            31,
            32,
            31,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[84] = new int[]{
            2084,
            31,
            31,
            32,
            31,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[85] = new int[]{
            2085,
            31,
            32,
            31,
            32,
            30,
            31,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[86] = new int[]{
            2086,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[87] = new int[]{
            2087,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[88] = new int[]{
            2088,
            30,
            31,
            32,
            32,
            30,
            31,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[89] = new int[]{
            2089,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[90] = new int[]{
            2090,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            return (bs[year][month]);
        }

        public bool IsLeapYear(int year)
        {
            //Calculates whether a english year is leap year or not
            if ((year % 100 == 0))
            {
                if ((year % 400 == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((year % 4 == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string GetNepaliMonth(int month)
        {
            switch ((month))
            {

                case 1:
                    return "Baisakh";
                case 2:
                    return "Jestha";
                case 3:
                    return "Ashad";
                case 4:
                    return "Shrawan";
                case 5:
                    return "Bhadra";
                case 6:
                    return "Ashwin";
                case 7:
                    return "Kartik";
                case 8:
                    return "Mangsir";
                case 9:
                    return "Poush";
                case 10:
                    return "Magh";
                case 11:
                    return "Falgun";
                case 12:
                    return "Chaitra";
                default:
                    return null;
            }

        }

        public string GetEnglishMonth(int month)
        {
            switch ((month))
            {

                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return null;
            }
        }
        public string GetDayOfWeek(int day)
        {

            switch ((day))
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                default:
                    return null;
            }
        }

        public System.DateTime ToAD()
        {
            return (this.ToAD(this._Date.ToShortDateString()));

        }

        public System.DateTime ToAD(string gDate)
        {

            int def_eyy = 0;
            int def_emm = 0;
            int def_edd = 0;
            int def_nyy = 0;
            int total_eDays = 0;
            int total_nDays = 0;
            int a = 0;
            int day = 0;
            int m = 0;
            int y = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int numDay = 0;

            //split nepali dates to get its year,month and day

            System.String[] userDateParts = gDate.Split(new[] { "/" }, System.StringSplitOptions.None);
            int mm = int.Parse(userDateParts[0]);
            int dd = int.Parse(userDateParts[1]);
            int yy = int.Parse(userDateParts[2]);

            //get starting nepali and english date for conversion 
            //Initialize english date
            Tuple<int, int[]> initializationDates = getClosestEnglishDateAndNepaliDateToAD(yy);

            int nepali_init_date = initializationDates.Item1;
            int[] english_init_date = initializationDates.Item2;
            //Initialize english date
            //def_eyy = 1943;
            //def_emm = 4;
            //def_edd = 13;

            def_eyy = english_init_date[0];
            def_emm = english_init_date[1];
            def_edd = english_init_date[2];

            //Equivalent nepali date
            // def_nyy = 2000;
            def_nyy = nepali_init_date;

            //Initializations
            total_eDays = 0;
            total_nDays = 0;
            a = 0;
            day = 3;
            m = 0;
            i = 0;

            //  k = 0;
            k = nepali_init_date;
            numDay = 0;

          


            int[] month = new int[]{
            0,
            31,
            28,
            31,
            30,
            31,
            30,
            31,
            31,
            30,
            31,
            30,
            31
        };

            int[] lmonth = new int[]{
            0,
            31,
            29,
            31,
            30,
            31,
            30,
            31,
            31,
            30,
            31,
            30,
            31
        };

            while ((i < (yy - def_nyy)))
            {
                j = 1;
                while ((j <= 12))
                {
                    total_nDays += getLastDayOfMonthNep(k, j);
                    j += 1;
                }

                i += 1;
                k += 1;
            }

            j = 1;
            while ((j < mm))
            {
                total_nDays += getLastDayOfMonthNep(k, j);
                j += 1;
            }
            total_nDays += dd;

            total_eDays = def_edd;
            m = def_emm;
            y = def_eyy;


            while ((!(total_nDays == 0)))
            {
                if ((IsLeapYear(y)))
                {
                    a = lmonth[m];
                }
                else
                {
                    a = month[m];
                }

                total_eDays += 1;
                day += 1;

                if ((total_eDays > a))
                {
                    m += 1;
                    total_eDays = 1;

                    if ((m > 12))
                    {
                        y += 1;
                        m = 1;
                    }
                }

                if ((day > 7))
                    day = 1;
                total_nDays -= 1;

            }
            numDay = day;

            return (new System.DateTime(y, m, total_eDays));
        }

        public System.String ToBS()
        {
            return (this.ToBS(this._Date));
        }

        public string ToBS(System.DateTime gDate)
        {

            //Breaking given english date
            int yy = 0;
            int mm = 0;
            int dd = 0;
            yy = gDate.Year;
            mm = gDate.Month;
            dd = gDate.Day;

            //English month data
            int[] month = new int[]{
            31,
            28,
            31,
            30,
            31,
            30,
            31,
            31,
            30,
            31,
            30,
            31
        };

            int[] lmonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int def_eyy = 0;
            int def_nyy = 0;
            int def_nmm = 0;
            int def_ndd = 0;
            int total_eDays = 0;
            int total_nDays = 0;
            int a = 0;
            int day = 0;
            int m = 0;
            int y = 0;
            int i = 0;
            int j = 0;
            int numDay = 0;

            //Initialize english date
            Tuple<int[], int[], int> initializationDates = getClosestEnglishDateAndNepaliDate(gDate);

            int[] english_init_date = initializationDates.Item1;
            int[] nepali_init_date = initializationDates.Item2;
            // def_eyy = 1944;
            def_eyy = english_init_date[0];

            //Equivalent nepali date
            def_nyy = nepali_init_date[0];
            def_nmm = nepali_init_date[1];
            def_ndd = nepali_init_date[2];
          
            //Initializations
            total_eDays = 0;
            total_nDays = 0;
            a = 0;
            day = 6;
            m = 0;
            i = 0;
            j = 0;
            numDay = 0;

            //Count total number of days in terms of year
            while ((i < (yy - def_eyy)))
            {
                j = 0;
                if ((IsLeapYear(def_eyy + i)))
                {
                    while ((j < 12))
                    {
                        total_eDays += lmonth[j];
                        j += 1;
                    }
                }
                else
                {
                    while ((j < 12))
                    {
                        total_eDays += month[j];
                        j += 1;
                    }

                }
                i += 1;
            }

            //Count total number of days in terms of month
            i = 0;
            while ((i < (mm - 1)))
            {
                if ((this.IsLeapYear(yy)))
                {
                    total_eDays += lmonth[i];
                }
                else
                {
                    total_eDays += month[i];
                }
                i += 1;
            }

            //Count total number of days in terms of dates
            total_eDays += dd;

            // i = 0;
            //below i is the starting nepali year, used in looping to loop through years above the specified year
            i = def_nyy;
            j = def_nmm;
            total_nDays = def_ndd;
            m = def_nmm;
            y = def_nyy;

            //Count nepali date from array
            while ((!(total_eDays == 0)))
            {
                a = this.getLastDayOfMonthNep(i, j);
                total_nDays += 1;
                day += 1;

                if ((total_nDays > a))
                {
                    m += 1;
                    total_nDays = 1;
                    j += 1;
                }

                if ((day > 7))
                    day = 1;
                if ((m > 12))
                {
                    y += 1;
                    m = 1;
                }

                if ((j > 12))
                {
                    j = 1;
                    i += 1;
                }
                total_eDays -= 1;
            }

            numDay = day;

            //return (new System.DateTime(y, m, total_nDays));
            //format = {4/30/2073 12:00:00 AM}
            string new_m = m.ToString();
            string new_d = total_nDays.ToString();
            if (m < 10)
            {
                new_m = "0" + m.ToString();
            }
            if (total_nDays < 10)
            {
                new_d = "0" + total_nDays.ToString();
            }
            string dat = new_m.ToString() + "-" + new_d.ToString() + "-" + y.ToString();
            return dat;
        }

        public double GetUnixTimestamp()
        {
            //create Timespan by subtracting the value provided from the Unix Epoch
            TimeSpan span = (_Date - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime());
            //return the total seconds (which is a UNIX timestamp)
            return span.TotalSeconds;
        }

        public double GetUnixTimestamp(System.DateTime gDate)
        {
            //Overloads
            //create Timespan by subtracting the value provided from the Unix Epoch
            TimeSpan span = (gDate - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime());
            //return the total seconds (which is a UNIX timestamp)
            return span.TotalSeconds;
        }

        public DateTime FormatUnixTime(double timestamp)
        {
            DateTime startUnixTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return startUnixTime.AddSeconds(timestamp).ToUniversalTime();
        }

        /// <summary>
        /// this function returns array of integer containing english year,month and day respectively as first return value and array of integer containing nepali year,month and day respectively as second return value
        /// </summary>
        /// <param name="english_date"></param>
        /// <returns></returns>
        public Tuple<int[], int[],int> getClosestEnglishDateAndNepaliDate(DateTime english_date)
        {
            try
            {
                if (english_date.Year >= 2034)
                    //  return Tuple.Create(new int[] { 2034 }, new int[] { 2090, 09, 16 }, 0);
                    throw new Exception("English date must be between 1944 and 2035.");

                else if (english_date.Year >= 2029)
                    return Tuple.Create(new int[] { 2029 }, new int[] { 2085, 09, 16 }, 1);

                else if (english_date.Year >= 2024)
                    return Tuple.Create(new int[] { 2024 }, new int[] { 2080, 09, 15 }, 1);

                else if (english_date.Year >= 2019)
                    return Tuple.Create(new int[] { 2019 }, new int[] { 2075, 09, 16 }, 2);

                else if (english_date.Year >= 2014)
                    return Tuple.Create(new int[] { 2014 }, new int[] { 2070, 09, 16 }, 3);

                else if (english_date.Year >= 2009)
                    return Tuple.Create(new int[] { 2009 }, new int[] { 2065, 09, 16 }, 4);

                else if (english_date.Year >= 2004)
                    return Tuple.Create(new int[] { 2004 }, new int[] { 2060, 09, 16 }, 4);

                else if (english_date.Year >= 1999)
                    return Tuple.Create(new int[] { 1999 }, new int[] { 2055, 09, 16 }, 5);

                else if (english_date.Year >= 1994)
                    return Tuple.Create(new int[] { 1994 }, new int[] { 2050, 09, 16 }, 6);

                else if (english_date.Year >= 1989)
                    return Tuple.Create(new int[] { 1989 }, new int[] { 2045, 09, 17 }, 0);

                else if (english_date.Year >= 1984)
                    return Tuple.Create(new int[] { 1984 }, new int[] { 2040, 09, 16 }, 0);

                else if (english_date.Year >= 1979)
                    return Tuple.Create(new int[] { 1979 }, new int[] { 2035, 09, 16 }, 1);

                else if (english_date.Year >= 1974)
                    return Tuple.Create(new int[] { 1974 }, new int[] { 2030, 09, 16 }, 2);


                else if (english_date.Year >= 1969)
                    return Tuple.Create(new int[] { 1969 }, new int[] { 2025, 09, 17 }, 3);

                else if (english_date.Year >= 1964)
                    return Tuple.Create(new int[] { 1964 }, new int[] { 2020, 09, 16 }, 3);

                else if (english_date.Year >= 1959)
                    return Tuple.Create(new int[] { 1959 }, new int[] { 2015, 09, 16 }, 4);

                else if (english_date.Year >= 1954)
                    return Tuple.Create(new int[] { 1954 }, new int[] { 2010, 09, 17 }, 5);

                else if (english_date.Year >= 1949)
                    return Tuple.Create(new int[] { 1949 }, new int[] { 2005, 09, 17 }, 6);

                else if (english_date.Year >= 1944)
                    return Tuple.Create(new int[] { 1944 }, new int[] { 2000, 09, 16 }, 6);
                else
                    throw new Exception("English date must be between 1944 and 2035.");
            }
            catch (Exception)
            {
                throw;
            }
        }



        /// <summary>
        /// this function returns array of integer containing nepali year as first return value and integer containing english year,month and day respectively as second return value
        /// </summary>
        /// <param name="english_date"></param>
        /// <returns></returns>
        public Tuple<int, int[]> getClosestEnglishDateAndNepaliDateToAD(int nep_year)
        {
            try
            {
                if (nep_year >= 2090)
                    throw new Exception("Nepali date must be between 2000 and 2090.");

                else if (nep_year >= 2085)
                    return Tuple.Create(2085, new int[] { 2028, 04, 12 });

                else if (nep_year >= 2080)
                    return Tuple.Create(2080, new int[] { 2023, 04, 13 });

                else if (nep_year >= 2075)
                    return Tuple.Create(2075, new int[] { 2018, 04, 13 });

                else if (nep_year >= 2070)
                    return Tuple.Create(2070, new int[] { 2013, 04, 13 });

                else if (nep_year >= 2065)
                    return Tuple.Create(2065, new int[] { 2008, 04, 12 });

                else if (nep_year >= 2060)
                    return Tuple.Create(2060, new int[] { 2003, 04, 13 });

                else if (nep_year >= 2055)
                    return Tuple.Create(2055, new int[] { 1998, 04, 13 });

                else if (nep_year >= 2050)
                    return Tuple.Create(2050, new int[] { 1993, 04, 12 });

                else if (nep_year >= 2045)
                    return Tuple.Create(2045, new int[] { 1988, 04, 12 });

                else if (nep_year >= 2040)
                    return Tuple.Create(2040, new int[] { 1983, 04, 13 });

                else if (nep_year >= 2035)
                    return Tuple.Create(2035, new int[] { 1978, 04, 13 });

                else if (nep_year >= 2030)
                    return Tuple.Create(2030, new int[] { 1973, 04, 12 });

                else if (nep_year >= 2025)
                    return Tuple.Create(2025, new int[] { 1968, 04, 12 });

                else if (nep_year >= 2020)
                    return Tuple.Create(2020, new int[] { 1963, 04, 13 });

                else if (nep_year >= 2015)
                    return Tuple.Create(2015, new int[] { 1958, 04, 12 });

                else if (nep_year >= 2010)
                    return Tuple.Create(2010, new int[] { 1953, 04, 12 });

                else if (nep_year >= 2005)
                    return Tuple.Create(2005, new int[] { 1948, 04, 12 });

                else if (nep_year >= 2000)
                    return Tuple.Create(2000, new int[] { 1943, 04, 13 });

                else
                    throw new Exception("Nepali Date must be between 2000 and 2090");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
