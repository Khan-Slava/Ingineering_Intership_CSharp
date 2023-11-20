using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Homework
{
    internal class Developer:Employee
    {
        int linesOfCodePerDay;
        decimal salaryForLineOfCode = 0;
        public Developer()
        {
            
        }
        public Developer(string name, int age, decimal salary, int linesOfCodePerDay, decimal salaryForLineOfCode = 0) : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
            this.salaryForLineOfCode = salaryForLineOfCode;
        }
        public override void CalculateAnnualSalary()
        {
            Console.WriteLine("Оплата за каждую строку: {0} ",salaryForLineOfCode);
            Console.WriteLine("Annual Salary For Developer: {0} ", (salary + linesOfCodePerDay*salaryForLineOfCode) * 12);
        }
    }
}
