// Copyright 2015 Jason Baisden. See LICENSE.txt for licensing info.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsPlayground.Extensions;

namespace ExtensionsPlayground
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime withinTest = DateTime.Now.AddDays(4);
            DateTime past = now.AddMonths(-1);
            DateTime future = now.AddMonths(1);
                        


            DateTime testDate1 = new DateTime(2015, 3, 3);
            DateTime testDate2 = new DateTime(2015, 3, 4);
            Console.WriteLine(
                string.Format("{0} is within 5 days of {1}? {2} (should be true)",
                    testDate1.ToShortDateString(), testDate2.ToShortDateString(), testDate1.IsWithIn(5.Days()).Of(testDate2)
                ));

            testDate1 = new DateTime(2015, 3, 1);
            testDate2 = new DateTime(2015, 3, 7);
            Console.WriteLine(
                string.Format("{0} is within 3 days of {1}? {2} (should be false)",
                    testDate1.ToShortDateString(), testDate2.ToShortDateString(), testDate1.IsWithIn(3.Days()).Of(testDate2)
                ));

            testDate1 = new DateTime(2015, 3, 3);
            testDate2 = new DateTime(2015, 4, 1);
            Console.WriteLine(
                 string.Format("{0} is within 1 month of {1}? {2} (should be true)",
                     testDate1.ToShortDateString(), testDate2.ToShortDateString(), testDate1.IsWithIn(1.Months()).Of(testDate2)
                 ));


            testDate1 = new DateTime(2015, 3, 3);
            testDate2 = new DateTime(2015, 6, 1);
            Console.WriteLine(
                string.Format("{0} is within 2 month of {1}? {2} (should be false)",
                    testDate1.ToShortDateString(), testDate2.ToShortDateString(), testDate1.IsWithIn(2.Months()).Of(testDate2)
                ));


            Console.WriteLine(
                string.Format("{0} is before {1} is {2} (should be true)",
                    now.ToShortDateString(), past.ToShortDateString(), now.IsBefore(future)
                ));

            Console.WriteLine(
                string.Format("{0} is after {1} is {2} (should be false)",
                    past.ToShortDateString(), now.ToShortDateString(), past.IsAfter(now)
                ));

            Console.WriteLine(
                string.Format("{0} is after {1} is {2} (should be true)",
                    now.ToShortDateString(), past.ToShortDateString(), now.IsAfter(past)
                ));

            Console.WriteLine(
                string.Format("{0} is between {1} and {2} is {3} (should be false)",
                    past.ToShortDateString(), now.ToShortDateString(), future.ToShortDateString(), past.IsBetween(now, future)
                ));

            Console.WriteLine(
                string.Format("{0} is between {1} and {2} is {3} (should be true)",
                    now.ToShortDateString(), past.ToShortDateString(), future.ToShortDateString(), now.IsBetween(past,future))
                );

            Console.ReadLine();
        }


        //static void Main2(string[] args)
        //{
        //    DateTime now = DateTime.Now;
        //    DateTime past = new DateTime(2015, 1, 15);
        //    DateTime future = new DateTime(2015, 3, 15);
        //    DateTime comparison = now.AddDays(-2);
        //    int interval = 1;
        //    DateInterval di = DateInterval.Days;

        //    Console.WriteLine(
        //        string.Format("Now, {0}, is with in {1} {2} of {3} is {4}",
        //            now.ToShortDateString(),
        //            interval.ToString(),
        //            di.ToString(),
        //            comparison.ToShortDateString(),
        //            now.IsDateWithinXRangeOfAnotherDate(interval, di, comparison).ToString())
        //    );

        //    Console.ReadLine();
        //}

    }



   

}
