using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public abstract class Demo //abstract class for Abstraction
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        private int id; //private data field, data hiding, Encapsulation

        public int Id //set property, data hiding, Encapsulation
        { 
            get { return id; } 
            private set { id = value; } //Encapsulation
        }
        public abstract void Work();

        public virtual void Salary() //Polymorphism
        {
            Console.WriteLine("Salary: 0");
        }
    }

    public class Student1: Demo //Inheritance
    {
        public override void Work()
        {
            Console.WriteLine("Student`s work: study, do assignment, exam");
        }
    }

    public class Instructor1 : Demo //Inheritance
    {
        public override void Work()
        {
            Console.WriteLine("Instructor`s work: meeting, teaching, grade assignment and exam");
        }

        public override void Salary()
        {
            Console.WriteLine("Instructor`s salary: 10000"); //Polymorphism
        }
    }
}
