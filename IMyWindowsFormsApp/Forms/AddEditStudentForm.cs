using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMyWindowsFormsApp
{
    public partial class AddEditStudentForm : Form
    {
        public Student StudentInfo { get; set; }
        public AddEditStudentForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StudentInfo.Age = Convert.ToInt32(txtAge.Text);
            StudentInfo.LastName = txtLastName.Text;
            StudentInfo.FirstName = txtFirstName.Text;
        }

        private void AddEditStudentForm_Load(object sender, EventArgs e)
        {
            if (StudentInfo != null)
            {
                txtAge.Text = StudentInfo.Age.ToString();
                txtLastName.Text = StudentInfo.LastName;
                txtFirstName.Text = StudentInfo.FirstName;
            }
        }
    }
}
