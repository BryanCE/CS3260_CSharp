using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2MainProj_BCE_V1
{
    public partial class LookupForm : Form
    {
        public LookupForm()
        {
            InitializeComponent();
        }


        public void updateLookupFormDisplay(string display)
        {
            txtDisplayEmpInfo.Clear();
            txtDisplayEmpInfo.Text = display;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtDisplayEmpInfo.Clear();
            var findEmp = BusinessRules.Instance.searchEmployee(txtEnterID.Text);

            //Hourly
            //Salary
            //Sales
            //Contract
            try
            {
                if (findEmp.EmpType == 0)//hourly //NullReferenceException possible
                {
                    //cast it to the correct type to access all it's data
                    Hourly emp;
                    emp = (Hourly)findEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nHourly Wage: " + emp.hourlyRate + "\nHours Worked: " + emp.hoursWorked);
                }
                else if (findEmp.EmpType == 1)
                {
                    Salary emp;
                    emp = (Salary)findEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nMonthly Salary: " + emp.monthlySalary);
                }
                else if (findEmp.EmpType == 2)
                {
                    Sales emp;
                    emp = (Sales)findEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nMonthly Salary: " + emp.monthlySalary + "\nGross Sales: " + emp.GrossSales + "\nCommision: " + emp.Commision);
                }
                else if (findEmp.EmpType == 3)
                {
                    Contract emp;
                    emp = (Contract)findEmp;
                    txtDisplayEmpInfo.AppendText("ID: " + emp.EmpID + "\nName: " + emp.FullName + "\nContract Wage: " + emp.contractWage);

                }
            }
            catch(NullReferenceException)
            {
                txtDisplayEmpInfo.Text = "The Employee you are Searching for does not exist! Try Again!";
            }

            txtEnterID.Clear();
            txtEnterID.Focus();
        }//end btnSearch_Click()

        private void btnCancelLookup_Click(object sender, EventArgs e)
        {
            txtEnterID.Clear();
            txtDisplayEmpInfo.Clear();
            this.Close();
        }
    }
}
