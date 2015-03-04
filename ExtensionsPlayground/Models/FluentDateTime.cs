using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsPlayground.Models
{



    public class FluentDateTime
    {

        public enum DateInterval
        {
            Days,
            Months,
            Years
        }

        private DateTime _lowDate;
        private DateTime _highDate;
        public DateTime BaseDate { get; set; }
        public DateInterval Interval { get; set; }
        public int Increment { get; set; }


        public bool Of(DateTime dt)
        {
            _lowDate = dt;
            _highDate = dt;

            if(this.Interval == DateInterval.Days)
            {
                _lowDate = _lowDate.AddDays(-this.Increment);
                _highDate = _highDate.AddDays(this.Increment);
            }
            else if (this.Interval == DateInterval.Months)
            {
                _lowDate = _lowDate.AddMonths(-this.Increment);
                _highDate = _highDate.AddMonths(this.Increment);
            }
            else
            {
                _lowDate = _lowDate.AddYears(-this.Increment);
                _highDate = _highDate.AddYears(this.Increment);
            }

            Console.WriteLine(
                string.Format("{0} <= {1} <= {2}", _lowDate.ToShortDateString(), BaseDate.ToShortDateString(), _highDate.ToShortDateString()
                ));

            return (_lowDate < BaseDate && BaseDate < _highDate) || (_lowDate.Equals(BaseDate) || _highDate.Equals(BaseDate) );            
        }

    }
}
