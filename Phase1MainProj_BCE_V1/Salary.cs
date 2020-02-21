using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phase1MainProj_BCE_V1
{
    [Serializable]
    public class Salary : Employee
    {
        internal double monthlySalary { get; set; }


        public Salary(double Id, double type, double salary, string full, string first, string last) : base(Id, type, full, first, last)
        {
            monthlySalary = salary;
        }
    }
}