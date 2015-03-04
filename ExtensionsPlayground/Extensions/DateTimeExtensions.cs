// Copyright 2015 Jason Baisden. See LICENSE.txt for licensing info.

using ExtensionsPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsPlayground.Extensions
{

    public static class DateTimeExtensions
    {

        public static FluentDateTime IsWithIn(this DateTime date, FluentDateTime fdtParams)
        {
            fdtParams.BaseDate = date;
            return fdtParams;
        }





        public enum DateComparisonResult
        {
            IsPast = -1,
            IsFuture = 1,
            TheSame = 0
        }

        public static bool IsBefore(this DateTime date, DateTime comparisonDate)
        {
            if (date.CompareTo(comparisonDate) == (int)DateComparisonResult.IsPast) return true;

            return false;
        }

        public static bool IsAfter(this DateTime date, DateTime comparisonDate)
        {
            if (date.CompareTo(comparisonDate) == (int)DateComparisonResult.IsFuture) return true;

            return false;
        }

        public static bool IsBetween(this DateTime date, DateTime oldestDate, DateTime nextOldest)
        {

            if (date.IsAfter(oldestDate) && date.IsBefore(nextOldest)) return true;

            return false;
        }


        public enum DateInterval
        {
            Days,
            Months,
            Years
        }

        public static bool IsDateWithinXRangeOfAnotherDate(this DateTime date, int interval, DateInterval dateInterval, DateTime comparisonDate)
        {
            DateTime _min = comparisonDate;
            DateTime _max = comparisonDate;

            switch(dateInterval)
            {
                case DateInterval.Days:
                    _min = _min.AddDays(-interval);
                    _max = _max.AddDays(interval); 
                    Console.WriteLine(
                        string.Format("Min Date is {0} Max Date is {1}",
                            _min.ToShortDateString(),
                            _max.ToShortDateString()));
                    break;
                case DateInterval.Months:
                    _min = _min.AddMonths(-interval);
                    _max = _max.AddMonths(interval);
                    Console.WriteLine(
                        string.Format("Min Date is {0} Max Date is {1}",
                            _min.ToShortDateString(),
                            _max.ToShortDateString()));
                    break;
                case DateInterval.Years:
                    _min = _min.AddYears(-interval);
                    _max = _max.AddYears(interval);
                    Console.WriteLine(
                        string.Format("Min Date is {0} Max Date is {1}",
                            _min.ToShortDateString(),
                            _max.ToShortDateString()));
                    break;
            }

            return _min <= date && date <= _max;
        }        
    }



}
