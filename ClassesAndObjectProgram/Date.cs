using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectProgram
{
    // Object is the super base class for all the classes in C#
    public class Date
    {
        // declare data members

        private int day, year;
        private string month;

        // method for assign the value to the data member
        public void AcceptDate(int dd, string mm, int yy)
        {
            day = dd;  // assignment done from right to left
            month = mm;
            year = yy;
        }
        // return the date to main method
        public string DisplayDate()
        {
            return $"Date is : {day} / {month} /{year}";
        }


    }
}
