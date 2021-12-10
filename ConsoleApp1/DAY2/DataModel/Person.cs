using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public class Person
    {
        public DateTime BirthDay { get; set; }
        public decimal MonthlySalary { get; set; }
        public string Address { get; set; }
    }

    public class Student: Person
    {
        public string[] Courses { get; set; }
        private String grade;
        public string Grade
        {
            get { return grade; }
            private set { grade = value; }
        }

    }

    public class Instructor : Person
    {
        public string Department { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
