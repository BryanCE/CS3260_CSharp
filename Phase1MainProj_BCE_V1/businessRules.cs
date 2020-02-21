using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phase1MainProj_BCE_V1
{
    sealed public class BusinessRules
    {
        private static BusinessRules instance = null;

        //public int empData;
        //private int lazy;

        public static BusinessRules Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BusinessRules();
                }
                return instance;
            }
        }

        public SortedDictionary<string, Employee> empData = new SortedDictionary<string, Employee>();
        private BusinessRules()
        {
            //throw new System.NotImplementedException();
        }

        public void addEmployee(string id, Employee emp)
        {
            empData.Add(id, emp); 
        }


        //double Id, double type, string first, string full, string last, double wage = 0.0, double rate = 0.0, double sales = 0.0
        public void updateEmployee(double Id, double type, string full, string first, string last, double wage = 0.0, double hours = 0.0, double rate = 0.0, double sales = 0.0)
        {
            if (type == 0)
            {
                //double Id, double type, double rate, double hours, string full, string first, string last
                Hourly employee = new Hourly(Id, type, rate, hours, full, first, last);
                empData[Id.ToString()] = employee;
            }
            else if (type == 1)
            {
                //public Salary(double Id, double type, double salary, string full, string first, string last) : base(Id, type, full, first, last)
                Salary employee = new Salary(Id, type, wage, full, first, last);
                empData[Id.ToString()] = employee;
            }
            else if (type == 2)
            {
                //public Sales(double Id, double type, double salary, double _commision, double sales, string full, string first, string last) : base(Id, type, salary, full, first, last)
                Sales employee = new Sales(Id, type, wage, rate, sales, full, first, last);
                empData[Id.ToString()] = employee;
            }
            else
            {
                //public Contract(double Id, double type, double wage, string full, string first, string last) : base(Id, type, full,first,last)
                Contract employee = new Contract(Id, type, wage, full, first, last);
                empData[Id.ToString()] = employee;
            }
        }
    }
}