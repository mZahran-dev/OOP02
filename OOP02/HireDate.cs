using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    #region 2.Develop a Class to represent the Hiring Date Data:
    public class HireDate
    {
        #region Attributes
        private int day;
        private int year;
        private int month;
        #endregion

        #region Constructor
        public HireDate(int _day, int _month, int _year)
        {
            day = _day;
            year = _month;
            month = _year;

        }
        #endregion

        #region property
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if (value < 1 || value > 31) throw new ArgumentException("Invalid day");
                day = value;
            }
        }
        public int Month
        {
            get
            {
                return month;
            }

            set
            {
                if (value < 1 || value > 31) throw new ArgumentException("Invalid month");
                month = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value < 1900 || value > DateTime.Now.Year) throw new ArgumentException("Invalid month");
                year = value;
            }
        }

        #endregion

        #region methods
        public int CompareTo(HireDate other)
        {
            if (other == null)
            {
                return 1;
            }
            if (year != other.year)
            {
                return year.CompareTo(other.year);
            }
            if (month != other.month)
            {
                return month.CompareTo(other.month);
            }

            return day.CompareTo(other.day);
        }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        #endregion
    }

    #endregion

}
