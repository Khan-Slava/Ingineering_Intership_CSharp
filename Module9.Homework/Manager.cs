using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Homework
{
    public class Manager: Employee
    {
        decimal bonus;
        public Manager()
        {
            
        }

        public Manager(string name, int age, decimal salary, decimal bonus) : base(name, age, salary)
        {
            this.bonus = bonus;
        }
        public override void CalculateAnnualSalary()
        {
            Console.WriteLine("Annual Salary with bonus: {0} ",(salary + bonus)*12 );
        }

    }
}
