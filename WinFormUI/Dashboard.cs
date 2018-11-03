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
            GenerateEmployeeID(firstNameText.Text, lastNameText.Text);
        }

        private string GenerateEmployeeID(string firstName, string lasteName)
        {
            return $"{ firstNameText.Text.Substring(0, 4) }{ lastNameText.Text.Substring(0, 4) }{ DateTime.Now.Millisecond }";
        }
    }
}
