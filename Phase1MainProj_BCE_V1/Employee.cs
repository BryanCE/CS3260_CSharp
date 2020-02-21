using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1MainProj_BCE_V1
{
    public abstract class Employee
    {
        private int empCount;
        internal double EmpID { get; set; }
        internal double EmpType { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FullName { get; set; }
        public Employee(double Id, double type, string full, string first, string last)
        {
            EmpID = Id;
            EmpType = type;
            FullName = full;
            FirstName = first;
            LastName = last;
            empCount++;
        }



    }
}
