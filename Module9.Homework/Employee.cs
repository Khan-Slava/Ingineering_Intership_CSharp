using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Homework
{
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public decimal salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(string name,int age,decimal salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void GetInfo() 
        {
            Console.WriteLine("name: {0} \n age: {1}\n salary: {2}",name,age,salary);
        }
        public virtual void CalculateAnnualSalary()
        {
            Console.WriteLine("AnnualSalary: {0}",salary * 12 );
        }    

    }
}
