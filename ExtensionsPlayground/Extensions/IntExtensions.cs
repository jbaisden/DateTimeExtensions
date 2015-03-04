using ExtensionsPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsPlayground.Extensions
{

    public static class IntExtensions
    {
        public static FluentDateTime Days(this int inc)
        {
            FluentDateTime fdt = new FluentDateTime();
            fdt.Interval = FluentDateTime.DateInterval.Days;
            fdt.Increment = inc;
            return fdt;
        }

        public static FluentDateTime Months(this int inc)
        {
            FluentDateTime fdt = new FluentDateTime();
            fdt.Interval = FluentDateTime.DateInterval.Months;
            fdt.Increment = inc;
            return fdt;
        }

        public static FluentDateTime Years(this int inc)
        {
            FluentDateTime fdt = new FluentDateTime();
            fdt.Interval = FluentDateTime.DateInterval.Years;
            fdt.Increment = inc;
            return fdt;
        }

    }
}
