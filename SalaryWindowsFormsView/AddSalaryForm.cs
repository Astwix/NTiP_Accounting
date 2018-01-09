using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryWindowsFormsView
{
    public partial class AddSalaryForm : Form
    {
        public SalaryModel.SalaryTypes.StaffSalary newStaff = null;
        public AddSalaryForm()
        {
            InitializeComponent();
        }

        public AddSalaryForm(SalaryModel.SalaryTypes.StaffSalary staff)
        {
            InitializeComponent();
            salaryControl1.SetStaff(staff);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            newStaff = salaryControl1.GetSalary();
            if (newStaff != null)
            {
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
