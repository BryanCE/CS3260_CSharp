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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        public void updateEmpDisplayList()
        {
            SavedEmpTxt.Clear();
            foreach(var x in BusinessRules.Instance.empData)
            {
                string fullName;
                string empID;
                fullName = x.Value.FullName.ToString();
                empID = x.Key;
                SavedEmpTxt.AppendText("ID: " + empID + "   Name: " + fullName + "\n");
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            //decided this wasn't very useful in indexing the employees
            //Random random = new Random();
            //string employeeId = random.Next(0, 100000).ToString();


            int totalEmps = BusinessRules.Instance.empData.Count;
            //making a new form for user to input the data
            var empInfoForm = new EmpInfoForm();
            //sends the employeeID to the other form for display
            empInfoForm.setEmpIDLabel(totalEmps.ToString());
            //this indicates who owns the empInfoFomr
            empInfoForm.Show(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //making a new form for user to input the data
            var aboutForm = new AboutForm();
            //this indicates who owns the empInfoFomr
            aboutForm.Show(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmpLookup_Click(object sender, EventArgs e)
        {
            //making a new form for user to input the data
            var empLookupForm = new LookupForm();
            //this indicates who owns the empInfoFomr
            empLookupForm.Show(this);
        }
    }
}
