using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Project Prolog
// Name: Bryan Edman
// CS3260 Section 001
// Project: Lab06
// Date: 2/28/2020
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

namespace Lab06_BCE_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Error check action if more than one letter is entered
        /// </summary>
        private void txtCharacter_TextChanged(object sender, EventArgs e)
        {
            char letter = ' ';
            if (txtCharacter.Text.Length != 0) { letter = txtCharacter.Text[0]; }
            if (txtCharacter.Text.Length > 1)
            {
                txtCharacter.Text = letter.ToString();
            }
        }

        public void ChangeLabel(string cmd)
        {
            this.lblFuncCalled.Text = "  ";
            this.lblFuncCalled.Text = cmd;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TestDelegate tg = new TestDelegate();
            int num;
            int.TryParse(txtNumber.Text, out num);
            double price;
            double.TryParse(txtPrice.Text, out price);
            char letter;
            char.TryParse(txtCharacter.Text, out letter);
            string word = txtWord.Text;

            txtDisplay.Text = tg.Getstring(num, price, letter, word);
        }

        /// <summary>
        /// Error check action if int is not entered
        /// </summary>
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(txtNumber.Text, out result)) { txtNumber.Text = ""; }
        }

        /// <summary>
        /// Error check action if double is not entered
        /// </summary>
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (!double.TryParse(txtPrice.Text, out result)) { txtPrice.Text = ""; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
