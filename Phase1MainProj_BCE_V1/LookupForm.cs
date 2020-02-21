using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase1MainProj_BCE_V1
{
    public partial class LookupForm : Form
    {
        public LookupForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtDisplayEmpInfo.Clear();
            try
            {
                //Hourly
                //Salary
                //Sales
                //Contract
                bool empIsThere = BusinessRules.Instance.empData.ContainsKey(txtEnterID.Text);
                var tempEmp = BusinessRules.Instance.empData[txtEnterID.Text];
                txtDisplayEmpInfo.Clear();
                if(tempEmp.EmpType == 0)//hourly
                {
                    //cast it to the correct type to access all it's data
                    Hourly emp;
                    emp = (Hourly)tempEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nHourly Wage: " + emp.hourlyRate + "\nHours Worked: " + emp.hoursWorked);
                }
                else if(tempEmp.EmpType == 1)
                {
                    Salary emp;
                    emp = (Salary)tempEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nMonthly Salary: " + emp.monthlySalary);
                }
                else if(tempEmp.EmpType == 2)
                {
                    Sales emp;
                    emp = (Sales)tempEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nMonthly Salary: " + emp.monthlySalary + "\nGross Sales: " + emp.GrossSales + "\nCommision: " + emp.Commision);
                }
                else if(tempEmp.EmpType == 3)
                {
                    Contract emp;
                    emp = (Contract)tempEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nContract Wage: " + emp.contractWage);

                }
            }
            catch(ArgumentNullException)
            {
                txtDisplayEmpInfo.Clear();
                txtDisplayEmpInfo.Text = "You did not enter a current Employee's ID! \nTry again or Cancel.";
            }
            catch(KeyNotFoundException)
            {
                txtDisplayEmpInfo.Clear();
                txtDisplayEmpInfo.Text = "You did not enter a current Employee's ID! \nTry again or Cancel.";
            }
        }

        private void btnCancelLookup_Click(object sender, EventArgs e)
        {
            txtEnterID.Clear();
            txtDisplayEmpInfo.Clear();
            this.Close();
        }
    }
}
