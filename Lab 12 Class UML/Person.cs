using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    abstract class Person
    {
        protected string Name;
        protected string Address;
        protected Person(string name, string address)
        {
            Name = name;
            Address = address;
        }


    }
}
