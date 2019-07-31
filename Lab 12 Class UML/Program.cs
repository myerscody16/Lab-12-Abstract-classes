using System;
using System.Collections.Generic;
namespace Lab_12_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>
            {
                new Student("Physics", 2, 8505.25, "John Doe","1570 Woodward"),
                new Student("Math", 1, 8407.62, "Kathryn Steele", "1571 Woodward"),
                new Student("Chemistry",4,7845.25,"Jane Doe","1572 Woodward"),
                new Staff("Mrs. Awesome","1573 Woodward","Cass tech",45000.15),
                new Staff("Mr. Cool", "1574 Woodward","Oakland",45000.15)
            };
            
        }
    }
}
