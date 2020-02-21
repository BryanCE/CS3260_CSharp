using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phase1MainProj_BCE_V1
{
    [Serializable]
    sealed class Sales : Salary
    {

        internal double Commision { get; set; }


        internal double GrossSales { get; set; }

        public Sales(double Id, double type, double salary, double _commision, double sales, string full, string first, string last) : base(Id, type, salary, full, first, last)
        {
            Commision = _commision;
            GrossSales = sales; 
         }


    }
}