using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectProgram
{
    public class Student
    {
        private int rollno;
        private string name;
        private float m1, m2, m3;
        private double total,percentage;

        public Student(int srollno, string sname,float sm1,float sm2,float sm3)
        {
            rollno = srollno;
            name = sname;
            m1 = sm1;
            m2 = sm2;
            m3 = sm3;
        }

        //public void CalculateTotalMarks()
        //{
        //    total=m1 + m2 + m3 ;

        //}

        public void CalculatePercentage()
        {
            total = (m1 + m2 + m3);
            percentage = (total/300) * 100;
        }

        public string Display()
        {
            return $"Total = {total} , Percentage = {percentage}";
        }

        

    }
}
