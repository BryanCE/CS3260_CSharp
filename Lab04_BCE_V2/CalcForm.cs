using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hopefully use to capture valid double expressions from strings
using System.Text.RegularExpressions;

namespace Lab04_BCE_V2
{
    /// <summary>
    /// Purpose: to control windows form and handle events
    /// </summary>
    public partial class CalcForm : Form
    {
        /// <summary>
        /// class data members for determining what operation to execute
        /// </summary>
        private bool add = false;
        private bool sub = false;
        private bool mult = false;
        private bool div = false;
        private bool success = true;
        private string command = "";
        private List<double> numList = new List<double>(4);
        private double lr, li, rr, ri;
        /// <summary>
        /// Constructor
        /// </summary>
        public CalcForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Segregates valid double values from string of chars
        /// </summary>
        /// <param name="cmnd">The string of chars built by input</param>
        private void getElements(string cmnd)
        {
            //searching the command string for appropriate double's to use
            //using regex to filter out what we want. 
            Regex rgx = new Regex(@"\d+\.\d+");
            foreach (Match m in rgx.Matches(cmnd))
            {
                numList.Add(Convert.ToDouble(m.Value));
            }
            //i'd like to make this more dynamic but just finding all
            //valid doubles in a string correctly took a while

            //if numlist doesn't have enough operands then something wasn't typed
            //in correctly
            if (numList.Count < 4)
            {
                success = false;
            }
            else
            {
                success = true;
                lr = numList[0];
                li = numList[1];
                rr = numList[2];
                ri = numList[3];
            }
            //change output based on error type
            switch (numList.Count)
            {
                case 0:
                    txtOutput.Text = "You've entered 0 valid values! Try Again.";
                    txtOutput.BackColor = Color.Red;
                    break;
                case 1:
                    txtOutput.Text = "You've only entered 1 valid values! Try Again.";
                    txtOutput.BackColor = Color.Red;
                    break;
                case 2:
                    txtOutput.Text = "You've only entered 2 valid values! Try Again.";
                    txtOutput.BackColor = Color.Red;
                    break;
                case 3:
                    txtOutput.Text = "You've only entered 3 valid values! Try Again.";
                    txtOutput.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            //clear out numlist for another use
            numList.Clear();
        }//end getElements()

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            if (txtOperand2.Text.Equals("Enter Complex Number 2"))
            {
                txtOperand2.Clear();
            }

            //txtOutput.Clear();
            //txtOutput.AppendText(txtOperand1.Text);
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            if (txtOperand1.Text.Equals("Enter Complex Number 1"))
            {
                txtOperand1.Clear();
            }
            //txtOutput.AppendText(txtOperand2.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            add = false;
            sub = false;
            div = true;
            mult = false;
            txtOutput.Clear();
            txtOutput.Text = "(" + txtOperand1.Text + ") ÷ (" + txtOperand2.Text + ")";
            command = txtOutput.Text.Replace(" ", "");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            add = false;
            sub = false;
            div = false;
            mult = true;
            txtOutput.Clear();
            txtOutput.Text = "(" + txtOperand1.Text + ") • (" + txtOperand2.Text + ")";
            command = txtOutput.Text.Replace(" ", "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            sub = false;
            div = false;
            mult = false;
            txtOutput.Clear();
            txtOutput.Text = "(" + txtOperand1.Text + ") + (" + txtOperand2.Text + ")";
            command = txtOutput.Text.Replace(" ", "");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            add = false;
            div = false;
            mult = false;
            sub = true;

            txtOutput.Clear();
            txtOutput.Text = "(" + txtOperand1.Text + ") - (" + txtOperand2.Text + ")";
            command = txtOutput.Text.Replace(" ", "");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            getElements(command);

            if (success)
            {
                ComplexData val1 = new ComplexData(lr, li);
                ComplexData val2 = new ComplexData(rr, ri);
                ComplexData result = null;
                ComplexArithmetic calc = new ComplexArithmetic();

                //check for comletely empty or default values
                //not empty and not default to enter
                if ((txtOperand1.Text != string.Empty && txtOperand2.Text != string.Empty) || (txtOperand1.Text != "Enter Complex Number 1" && txtOperand2.Text != "Enter Complex Number 2"))
                {
                    if (div)
                    {
                        result = calc.Divide(val1, val2);
                    }
                    else if (mult)
                    {
                        result = calc.Multiply(val1, val2);
                    }
                    else if (sub)
                    {
                        result = calc.Subtract(val1, val2);
                    }
                    else if (add)
                    {
                        result = calc.Add(val1, val2);
                    }
                    else
                    {
                        btnClear.PerformClick();
                        lblInstructions.Text = "SORRY SOMETHING WENT WRONG!";
                    }
                }//end if input=default or empty
                txtOutput.Clear();
                txtOutput.Text = result.ToString();
            }//end if(sucess)

            //reeturn command to empty string
            command = "";
        }//end btnEquals

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            txtOutput.BackColor = Color.White;
            txtOperand1.Focus();
            div = false;
            mult = false;
            sub = false;
            add = false;
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtOperand1.Clear();
            txtOperand2.Clear();
            txtOutput.Clear();
            txtOutput.BackColor = Color.White;
            div = false;
            mult = false;
            sub = false;
            add = false;
        }
    }
}