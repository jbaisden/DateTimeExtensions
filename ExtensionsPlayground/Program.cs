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
            DateTime past = now.AddMonths(-1);
            DateTime future = now.AddMonths(1);
            
            Console.WriteLine(
                string.Format("{0} is before {1} is {2} (should be false)",
                    now.ToShortDateString(), past.ToShortDateString(), now.IsBefore(past)
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


        static void Main2(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime past = new DateTime(2015, 1, 15);
            DateTime future = new DateTime(2015, 3, 15);
            DateTime comparison = now.AddDays(-2);
            int interval = 1;
            DateInterval di = DateInterval.Days;

            Console.WriteLine(
                string.Format("Now, {0}, is with in {1} {2} of {3} is {4}",
                    now.ToShortDateString(),
                    interval.ToString(),
                    di.ToString(),
                    comparison.ToShortDateString(),
                    now.IsDateWithinXRangeOfAnotherDate(interval, di, comparison).ToString())
            );

            Console.ReadLine();
        }

    }



   

}
