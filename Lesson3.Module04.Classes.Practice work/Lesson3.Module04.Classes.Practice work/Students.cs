using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Module04.Classes.Practice_work
{
    struct Students
    {
        public string FullName;
        public string GroupNumber;
        public int[] Grades;

        public Students(string FullName, string GroupNumber, int[] Grades)
        {
            this.FullName = FullName;
            this.GroupNumber = GroupNumber;
            this.Grades = Grades;
        }

        public double GetAverageGrade()
        {
            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }

        public bool HasOnlyGoodGrades()
        {
            foreach (int grade in Grades)
            {
                if (grade < 4)
                    return false;
            }
            return true;
        }
    }
}
