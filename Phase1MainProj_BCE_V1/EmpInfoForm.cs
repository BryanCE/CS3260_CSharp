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
    public partial class EmpInfoForm : Form
    {
        string typeofEmployee;
        public EmpInfoForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        lblPayType.Text = "Wage*";
                        txtHoursWorked.Visible = true;
                        lblCommision.Visible = false;
                        txtCommision.Visible = false;
                        typeofEmployee = "Hourly";
                        break;
                    case 1:
                        lblPayType.Text = "Monthly Salary*";
                        txtHoursWorked.Visible = false;
                        lblHours.Visible = false;
                        lblCommision.Visible = false;
                        txtCommision.Visible = false;
                        typeofEmployee = "Salary";
                        break;
                    case 2:
                        lblPayType.Text = "Monthly Salary*";
                        lblHours.Text = "Gross Sales*";
                        lblHours.Visible = true;
                        lblHours.Text = "Gross Sales*";
                        txtHoursWorked.Visible = true;
                        lblCommision.Visible = true;
                        txtCommision.Visible = true;
                        typeofEmployee = "Sales";
                        break;
                    case 3:
                        lblPayType.Text = "Contract Salary*";
                        lblHours.Visible = false;
                        txtHoursWorked.Visible = false;
                        lblCommision.Visible = false;
                        txtCommision.Visible = false;
                        typeofEmployee = "Contract";
                        break;
                    default:
                        break;

                }//end switch
            }//end try
            catch(ArgumentOutOfRangeException)
            {
                lblError.Text = "You have Caused an Error with your employment type, please try again.";
            }

        }

        /// <summary>
        /// Changes the text of the employee ID label
        /// </summary>
        /// <param name="text"></param>
        public void setEmpIDLabel(string text)
        {
            this.lblDisplayEmpID.Text = text; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //catching our random employee ID number and parsing it. 
            double.TryParse(lblDisplayEmpID.Text, out double id);

            try
            {
                switch (typeofEmployee)
                {
                    case "Hourly":
                        Hourly hourlyEmp = new Hourly(id, 0, Convert.ToDouble(txtPayType.Text), Convert.ToDouble(txtHoursWorked.Text), txtFName.Text + " " + txtLName.Text, txtFName.Text, txtLName.Text);
                        BusinessRules.Instance.addEmployee(id.ToString(), hourlyEmp);
                        break;
                    case "Salary":
                        Salary salaryEmp = new Salary(id, 1, Convert.ToDouble(txtPayType.Text), txtFName.Text + " " + txtLName.Text, txtFName.Text, txtLName.Text);
                        BusinessRules.Instance.addEmployee(id.ToString(), salaryEmp);
                        break;
                    case "Sales":
                        Sales salesEmp = new Sales(id, 2, Convert.ToDouble(txtPayType.Text), Convert.ToDouble(txtCommision.Text), Convert.ToDouble(txtHoursWorked.Text), txtFName.Text + " " + txtLName.Text, txtFName.Text, txtLName.Text);
                        BusinessRules.Instance.addEmployee(id.ToString(), salesEmp);
                        break;
                    case "Contract":
                        Contract contractEmp = new Contract(id, 3, Convert.ToDouble(txtPayType.Text), txtFName.Text + " " + txtLName.Text, txtFName.Text, txtLName.Text);
                        BusinessRules.Instance.addEmployee(id.ToString(), contractEmp);
                        break;
                    default:
                        break;
                }
                lblError.Text = " ";
                
            }
            catch (FormatException error)
            {
                lblError.Text = "Some Pay type, hours worked, or other number value was not valid." + error;
                txtPayType.Focus();
            }
            catch (OverflowException error)
            {
                lblError.Text = "Some Pay type, hours worked, or other number value was not valid." + error;
                txtPayType.Focus();
            }


            MainForm mainForm = (MainForm)Owner;
            mainForm.updateEmpDisplayList();
            //mainForm.ShowDialog();
            //close this entry form
            this.Close();
        }//end btSave_click
        /// <summary>
        /// closes the Employee information winform if user decides to cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
//Hourly
//Salary
//Sales
//Contract