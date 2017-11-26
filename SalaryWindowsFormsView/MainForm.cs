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
using Newtonsoft.Json;
using System.IO;

namespace SalaryWindowsFormsView
{
    public partial class MainForm : Form
    {
        List<SalaryModel.SalaryTypes.StaffSalary> StaffList = new List<SalaryModel.SalaryTypes.StaffSalary> ();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm form1 = new AddForm();
            form1.ShowDialog();
            if (form1.newStaff != null)
            {
                StaffList.Add(form1.newStaff);
                EmployeesGridView.Rows.Add(form1.newStaff.Firstname, form1.newStaff.Surname, form1.newStaff.GetSalaryValue());
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (SalaryModel.SalaryTypes.StaffSalary staff in StaffList)
                {
                    if (staff.Firstname == EmployeesGridView.CurrentRow.Cells[0].Value.ToString()
                        && staff.Surname == EmployeesGridView.CurrentRow.Cells[1].Value.ToString()
                        && staff.GetSalaryValue().ToString() == EmployeesGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                        EmployeesGridView.Rows.Remove(EmployeesGridView.CurrentRow);
                        StaffList.Remove(staff);
                        break;
                    }
                }
            }
            catch(System.ArgumentNullException)
            {
                MessageBox.Show("nope");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null; 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\"; 
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            openFileDialog1.FilterIndex = 2; 
            openFileDialog1.RestoreDirectory = true; 

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                try 
                { 
                    if ((myStream = openFileDialog1.OpenFile()) != null) 
                    { 
                        using (myStream) 
                        { 
                            var settings = new JsonSerializerSettings 
                            { 
                                TypeNameHandling = TypeNameHandling.All 
                            }; 
                            StreamReader sr = new StreamReader(myStream);
                            StaffList = JsonConvert.DeserializeObject<List<SalaryModel.SalaryTypes.StaffSalary>>(sr.ReadLine(), settings); 
                            sr.Close(); 
                            myStream.Close();
                            EmployeesGridView.Rows.Clear();
                            foreach (SalaryModel.SalaryTypes.StaffSalary staff in StaffList) 
                            {
                                EmployeesGridView.Rows.Add(staff.Firstname, staff.Surname, staff.GetSalaryValue());
                            } 
                        } 
                    } 
                } 
                catch (Exception ex) 
                { 
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message); 
                } 
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            }; 
            string db = JsonConvert.SerializeObject(StaffList, settings);
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(myStream);
                    sw.WriteLine(db);
                    sw.Flush();
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        private void AddRandomEmp_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string name = "Имя" + rnd.Next(1, 100);
            string surname = "Фамилия" + rnd.Next(1, 100);
            SalaryModel.SalaryTypes.StaffSalary staff;

            if (rnd.Next(0, 2) == 1)
            {
                staff = new SalaryModel.SalaryTypes.HourlyWage(name, surname, rnd.Next(1, 300), rnd.Next(1, 200));
            }
            else
            {
                staff = new SalaryModel.SalaryTypes.MonthlyWage(name, surname, rnd.Next(10000,100000),rnd.Next(10, 200)*0.01,rnd.Next(0,5000));
            }
            StaffList.Add(staff);
            EmployeesGridView.Rows.Add(staff.Firstname, staff.Surname, staff.GetSalaryValue());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
