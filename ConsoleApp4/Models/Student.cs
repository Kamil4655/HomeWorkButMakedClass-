using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Student
    {
        public string Name;
        public string Surname;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }

    class Person : Student
    {
        public string Group;
        public byte Point; 
        public bool IsGraduated;

        public Person(string name, string surname, string group, byte point) : base(name, surname)
        {
            Group = group;
            Point = point;
            IsGraduated = point >= 65;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name} \nSurname: {Surname} \nGroup: {Group} \nPoint: {Point} \nIs Graduated: {(IsGraduated ? "He" : "Yox")}\n ");

        }

        public void CheckGraduation()
        {
            Console.WriteLine($"Graduation Status: {(IsGraduated ? "Bu telebe mezun olub" : "Mezun olmayib")}");
        }

        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("Diplom dusmur");
            }
            else if (Point >= 65 && Point < 80)
            {
                Console.WriteLine("Adi diploma dushub");
            }
            else if (Point >= 80 && Point < 90)
            {
                Console.WriteLine("Seref diplomuna dushub");
            }
            else
            {
                Console.WriteLine("Yuksek Seref diplomuna dushub");
            }
        }
    }
}
