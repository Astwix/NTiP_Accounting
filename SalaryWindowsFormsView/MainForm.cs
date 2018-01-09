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
            AddSalaryForm addSalaryForm = new AddSalaryForm();
            addSalaryForm.ShowDialog();
            if (addSalaryForm.newStaff != null)
            {
                StaffList.Add(addSalaryForm.newStaff);
                EmployeesGridView.Rows.Add(addSalaryForm.newStaff.Firstname, addSalaryForm.newStaff.Surname, addSalaryForm.newStaff.GetSalaryValue());
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
            Stream fileStream = null; 
            OpenFileDialog openSalaryFileDialog = new OpenFileDialog();

            openSalaryFileDialog.InitialDirectory = "c:\\"; 
            openSalaryFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            openSalaryFileDialog.FilterIndex = 2; 
            openSalaryFileDialog.RestoreDirectory = true; 

            if (openSalaryFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                try 
                { 
                    if ((fileStream = openSalaryFileDialog.OpenFile()) != null) 
                    { 
                        using (fileStream) 
                        { 
                            var settings = new JsonSerializerSettings 
                            { 
                                TypeNameHandling = TypeNameHandling.All 
                            }; 
                            StreamReader sr = new StreamReader(fileStream);
                            StaffList = JsonConvert.DeserializeObject<List<SalaryModel.SalaryTypes.StaffSalary>>(sr.ReadLine(), settings); 
                            sr.Close(); 
                            fileStream.Close();
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
                staff = new SalaryModel.SalaryTypes.HourlyWage(name, surname, rnd.Next(1, 300), rnd.Next(80, 200));
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            SalaryModel.SalaryTypes.StaffSalary selectedStaff = null;
            try
            {
                foreach (SalaryModel.SalaryTypes.StaffSalary staff in StaffList)
                {
                    if (staff.Firstname == EmployeesGridView.CurrentRow.Cells[0].Value.ToString()
                        && staff.Surname == EmployeesGridView.CurrentRow.Cells[1].Value.ToString()
                        && staff.GetSalaryValue().ToString() == EmployeesGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                        selectedStaff = staff;
                        break;
                    }
                }
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Wrong");
            }
            if (selectedStaff != null)
            {
                AddSalaryForm editSalaryForm = new AddSalaryForm(selectedStaff);
                editSalaryForm.ShowDialog();
                if (editSalaryForm.newStaff != null)
                {
                    StaffList.Remove(selectedStaff);
                    StaffList.Add(editSalaryForm.newStaff);
                    EmployeesGridView.CurrentRow.SetValues(editSalaryForm.newStaff.Firstname, editSalaryForm.newStaff.Surname, editSalaryForm.newStaff.GetSalaryValue());
                }
            }
        }
    }
}
