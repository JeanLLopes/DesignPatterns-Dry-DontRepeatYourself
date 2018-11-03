using Library;
using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            EmployeeProcessor employeeProcessor = new EmployeeProcessor();
            employeeIdText.Text = employeeProcessor.GenerateEmployeeID(firstNameText.Text, lastNameText.Text);
        }
    }
}
