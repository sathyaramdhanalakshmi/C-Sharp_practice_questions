using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string name, int age, int studentId) : base(name, age)
        {
            StudentId = studentId;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
        }
    }
}
