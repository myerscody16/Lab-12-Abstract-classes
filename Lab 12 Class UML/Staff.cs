using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff(string name, string address, string school, double pay):base(name,address)
        {
            this.School = school;
            this.Pay = pay;
        }
        public override string ToString()
        {
            return $"school:{School}, pay:{Pay}";
        }
    }
}
