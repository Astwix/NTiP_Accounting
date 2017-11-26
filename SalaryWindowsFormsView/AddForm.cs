using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryModel;

namespace SalaryWindowsFormsView
{
    public partial class AddForm : Form
    {
        public SalaryModel.SalaryTypes.StaffSalary newStaff = null;

        public AddForm()
        {
            InitializeComponent();
            HourPriceTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            RewardTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            RateTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            BountyTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            FirstnameTextBox.KeyPress += new KeyPressEventHandler(IsString);
            SurnameTextBox.KeyPress += new KeyPressEventHandler(IsString);
            HoursWorkedTextBox.KeyPress += new KeyPressEventHandler(IsNumber);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (HourlyWageRadioButton.Checked == true)
                {
                    newStaff = new SalaryModel.SalaryTypes.HourlyWage(FirstnameTextBox.Text,
                        SurnameTextBox.Text, Convert.ToDouble(HourPriceTextBox.Text),
                        Convert.ToDouble(HoursWorkedTextBox.Text));
                }
                if (MonthlyWageRadioButton.Checked == true)
                {
                    newStaff = new SalaryModel.SalaryTypes.MonthlyWage(FirstnameTextBox.Text,
                        SurnameTextBox.Text, Convert.ToDouble(RewardTextBox.Text), Convert.ToDouble(RateTextBox.Text),
                        Convert.ToDouble(BountyTextBox.Text));
                }
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void IsNumberOrDotPressed(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsControl(e.KeyChar))
                && !(Char.IsDigit(e.KeyChar))
                && !((e.KeyChar == '.')
                && (((TextBox)sender).Text.IndexOf(".")==-1)
                && (((TextBox)sender).Text.IndexOf(",")==-1))
                && !((e.KeyChar == ',')
                && (((TextBox)sender).Text.IndexOf(",")==-1)
                && (((TextBox)sender).Text.IndexOf(".")==-1))
                )
            {
                e.Handled = true;
            }
        }

        private void IsNumber(object sender, KeyPressEventArgs n)
        { 
            if(!(Char.IsControl(n.KeyChar))
                && !(Char.IsDigit(n.KeyChar))
                )
            {
                n.Handled = true;
            }
        }

        private void IsString(object sender, KeyPressEventArgs s)
        {
            if (!(Char.IsControl(s.KeyChar))
                && !(Char.IsLetter(s.KeyChar))
                && !((s.KeyChar == '-')
                && (((TextBox)sender).Text.IndexOf("-") == -1))
                )
            {
                s.Handled = true;
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            HourlyWageGroupBox.Enabled = false;
            MonthlyWageGroupBox.Enabled = false;
            BountyTextBox.Enabled = false;
            BountyTextBox.Text = "0";
        }

        private void HourlyWageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HourlyWageGroupBox.Enabled = true;
            MonthlyWageGroupBox.Enabled = false;
        }

        private void MonthlyWageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MonthlyWageGroupBox.Enabled = true;
            HourlyWageGroupBox.Enabled = false;
        }

        private void BountyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BountyCheckBox.Checked)
            {
                BountyTextBox.Enabled = true;
            }
            else
            {
                BountyTextBox.Enabled = false;
                BountyTextBox.Text = "0";
            }
        }

        private void FirstnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
