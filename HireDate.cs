using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentD07
{
    enum Gender
    {
        F,
        M,
    }

    [Flags]
    enum SecurityLevel
    {
        guest = 1,
        Developer = 2,
        secretary = 4 ,
        DBA = 8 ,
        securityOfficer = 16 ,
    }

    internal class HireDate
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
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
                year = value;
            }
        }

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }

        public int CompareTo(object obj)
        {
            HireDate right = (HireDate)obj;
            return this.year.CompareTo(right.year);
        }



    }
}
