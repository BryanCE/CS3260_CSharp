using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2MainProj_BCE_V1
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
        public List<Employee> empList; 
        /// <summary>
        /// default constructor
        /// </summary>
        private BusinessRules()
        {
        }

        /// <summary>
        /// Constructor that takes in a List of employees and copies it to empData and empList
        /// because Lists have much more functionality for searching and finding elements
        /// using for Unit testing currently
        /// </summary>
        /// <param name="SDictionary"></param>
        public BusinessRules(List<Employee> _empList)
        {
            _empList.ForEach(item => empData.Add(item.EmpID.ToString(), item));
            empList = _empList;
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
        }//end updateEmployee


        /// <summary>
        /// searches through the businessrule empData to find a specific employee
        /// </summary>
        /// <param name="nameID">a name or an id number</param>
        /// <returns>employee info to display</returns>
        public Employee searchEmployee(string nameID)
        {
            try
            {
                if (int.TryParse(nameID, out int id))
                {
                    if (empData.Keys.Contains(id.ToString()))
                    {
                        return empData[id.ToString()];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    foreach (var x in empData.Keys)
                    {
                        if (empData[x].FirstName == nameID || empData[x].LastName == nameID || empData[x].FullName == nameID)
                        {
                            return empData[x];
                        }
                    }

                }
                return null;
            }//end try
            catch(ArgumentNullException)
            {
                //getting access to the Lookupform. 
                var form = Application.OpenForms.Cast<LookupForm>().Where(x => x.Name == "LookupForm").FirstOrDefault();
                form.updateLookupFormDisplay("The Employee you are Searching for does not exist! Try Again!");
                return null;
            }
            catch(KeyNotFoundException)
            {
                //getting access to the Lookupform. 
                var form = Application.OpenForms.Cast<LookupForm>().Where(x => x.Name == "LookupForm").FirstOrDefault();
                form.updateLookupFormDisplay("The Employee you are Searching for does not exist! Try Again!");
                return null;
            }
        }//end searchEmployee()
    }
}