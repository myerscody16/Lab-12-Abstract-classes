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
        public Student(string program, int year, double fee, string name, string address):base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }
        public override string ToString()
        {
            return $"program: {Program}, year: {Year}, fee: {Fee}" ;
        }
    }
}
