using System.Collections.Generic;

namespace DateConverter.Core.Library
{
    public class NepaliDateData : iNepaliDateData
    {
        public int getLastDayOfMonthNep(int year, int month)
        {
            Dictionary<int, int[]> daysInMonthByYear = new Dictionary<int, int[]>();
            daysInMonthByYear.Add(1970, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1971, new int[] { 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1972, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(1973, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(1974, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1975, new int[] { 31, 31, 32, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1976, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(1977, new int[] { 30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(1978, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1979, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1980, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(1981, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1982, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1983, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1984, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(1985, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1986, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1987, new int[] { 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1988, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(1989, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1990, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1991, new int[] { 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1992, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(1993, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1994, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1995, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(1996, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(1997, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1998, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(1999, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2000, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(2001, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2002, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2003, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2004, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2005, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2006, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2007, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2008, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });

            daysInMonthByYear.Add(2009, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2010, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2011, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2012, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2013, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2014, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2015, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2016, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2017, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2018, new int[] { 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2019, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2020, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2021, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2022, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(2023, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2024, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2025, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2026, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2027, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2028, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2029, new int[] { 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2030, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2031, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2032, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2033, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2034, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2035, new int[] { 30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });

            daysInMonthByYear.Add(2036, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2037, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2038, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2039, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2040, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2041, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2042, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2043, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2044, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2045, new int[] { 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2046, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2047, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2048, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2049, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });

            daysInMonthByYear.Add(2050, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(2051, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2052, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2053, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(2054, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2055, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2056, new int[] { 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2057, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2058, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2059, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2060, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2061, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });

            daysInMonthByYear.Add(2062, new int[] { 30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2063, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2064, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2065, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2066, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });
            daysInMonthByYear.Add(2067, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2068, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2069, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2070, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2071, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2072, new int[] { 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2073, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2074, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2075, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2076, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(2077, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            daysInMonthByYear.Add(2078, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2079, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });

            daysInMonthByYear.Add(2080, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(2081, new int[] { 31, 31, 32, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2082, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2083, new int[] { 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2084, new int[] { 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2085, new int[] { 31, 32, 31, 32, 30, 31, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2086, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2087, new int[] { 31, 31, 32, 31, 31, 31, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2088, new int[] { 30, 31, 32, 32, 30, 31, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2089, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });

            daysInMonthByYear.Add(2090, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2091, new int[] { 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2092, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2093, new int[] { 31, 32, 31, 31, 31, 31, 30, 29, 30, 29, 30, 31 });
            daysInMonthByYear.Add(2094, new int[] { 31, 31, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2095, new int[] { 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2096, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2097, new int[] { 31, 32, 31, 31, 31, 31, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2098, new int[] { 31, 31, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2099, new int[] { 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            daysInMonthByYear.Add(2100, new int[] { 31, 32, 31, 32, 30, 31, 30, 29, 30, 29, 30, 30 });


            daysInMonthByYear.Add(2101, new int[] { 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2102, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2103, new int[] { 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2104, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2105, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2106, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2107, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(2108, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2109, new int[] { 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2110, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2111, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            daysInMonthByYear.Add(2112, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2113, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2114, new int[] { 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2115, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2116, new int[] { 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });

            daysInMonthByYear.Add(2117, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2118, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2119, new int[] { 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            daysInMonthByYear.Add(2120, new int[] { 30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });

            daysInMonthByYear.Add(2121, new int[] { 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            daysInMonthByYear.Add(2122, new int[] { 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });

            return (daysInMonthByYear[year])[month - 1];
        }
    }
}

