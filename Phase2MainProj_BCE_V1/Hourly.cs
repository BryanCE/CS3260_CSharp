using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phase2MainProj_BCE_V1
{
    public sealed class Hourly : Employee
    {
        internal double hourlyRate { get; set; }
        internal double hoursWorked { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Hourly() : base ()
        {

        }
        public Hourly(double Id, double type, double rate, double hours, string full, string first, string last) : base(Id, type, full, first, last)
        {
            hourlyRate = rate;
            hoursWorked = hours;
        }
    }
}