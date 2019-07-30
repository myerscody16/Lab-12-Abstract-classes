using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Staff : Person
    {
        private string School;
        private double Pay;
        public Staff(string name, string address) : base(name, address)
        {

        }
    }
}
