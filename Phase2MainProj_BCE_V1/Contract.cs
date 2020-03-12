using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phase2MainProj_BCE_V1
{
    public sealed class Contract : Employee
    {
        internal double contractWage { get; set; }
        public Contract(double Id, double type, double wage, string full, string first, string last) : base(Id, type, full,first,last)
        {
            contractWage = wage; 
        }



    }
}