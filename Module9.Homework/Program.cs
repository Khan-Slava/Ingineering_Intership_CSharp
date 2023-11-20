using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Employee");
            Employee manager = new Employee("Slava",20,100000);
            manager.GetInfo();
            manager.CalculateAnnualSalary();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("For Manager");
            manager = new Manager("Slava", 20, 100000, 12345);
            manager.CalculateAnnualSalary();
            manager.GetInfo();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("For Employee");
            Employee developer = new Employee("Tomas", 22, 157000);
            developer.GetInfo();
            developer.CalculateAnnualSalary();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("For Developer");
            developer = new Developer("Slava", 20, 100000, 150,9);
            developer.CalculateAnnualSalary();
            developer.GetInfo();

        }
    }
}
