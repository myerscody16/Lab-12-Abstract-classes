using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Student: Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string name, string address):base(name, address)
        {
            Program = "Science";
            Year = 12;
            Fee = 3258.20;
        }
    }
}
