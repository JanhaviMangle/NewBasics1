using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
   public class EmployeeTest
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.input();
            decimal np = e1.CalculateSalary();
            e1.display();
            Console.WriteLine("net salary:" + np);
            Console.WriteLine("========================");
        }
    }
}
