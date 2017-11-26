using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryModel.SalaryTypes;

namespace SalaryConsoleView
{
    class Program
    {
        public static List<StaffSalary> allEmp = new List<StaffSalary>();
        static void Main(string[] args)
        {
            ShowMenu();
        }
        /// <summary>
        /// Вывод меню
        /// </summary>
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Create employee with per hour salary.");
            Console.WriteLine("2. Create employee with monthly salary.");
            Console.WriteLine("3. Generate eployee.");
            Console.WriteLine("4. Display information about employers.");
            Console.WriteLine("0. Exit");
            int entered = TryParseInt();
            switch (entered)
            {
                case 1:
                    AddHourlyWage();
                    break;
                case 2:
                    AddMounthlyWage();
                    break;
                case 3:
                    GenerateEmployee();
                    break;
                case 4:
                    ShowAll();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        /// <summary>
        /// Добавление сотредника с почасовой з.п.
        /// </summary>
        static void AddHourlyWage()
        {
            Console.Clear();
            Console.WriteLine("Enter firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter cost per hour:");
            double hourPrice = TryParseDouble();
            Console.WriteLine("Enter hours worked:");
            double hoursWorked = TryParseDouble();
            StaffSalary staff = null;
            try
            {

                staff = new HourlyWage(firstname, surname, hourPrice, hoursWorked);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect data. " + e.Message);
            }
            if (staff != null)
            {
                allEmp.Add(staff);
            }
            Console.WriteLine("Done. Press any key.");
            Console.ReadKey();
            ShowMenu();
        }
        /// <summary>
        /// Добавление сотрудника с месячным окладом
        /// </summary>
        static void AddMounthlyWage()
        {
            Console.Clear();
            Console.WriteLine("Enter firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter mounthly reward:");
            double reward = TryParseDouble();
            Console.WriteLine("Enter individual rate:");
            double rate = TryParseDouble();
            Console.WriteLine("Enter individual bounty:");
            double bounty = TryParseDouble();
            StaffSalary staff = null;
            try
            {
                staff = new MonthlyWage(firstname, surname, reward, rate, bounty);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect data. " + e.Message);
            }
            if (staff != null)
            {
                allEmp.Add(staff);
            }
            Console.WriteLine("Done. Press any key.");
            Console.ReadKey();
            ShowMenu();
        }
        /// <summary>
        /// Генерация сотрудников
        /// </summary>
        static void GenerateEmployee()
        {
            Console.Clear();
            StaffSalary staff1 = null;
            try
            {
                staff1 = new MonthlyWage("Ann", "Swan", 50000, 1, 1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect data. " + e.Message);
            }
            if (staff1 != null)
            {
                allEmp.Add(staff1);
            }
            
            StaffSalary staff2 = null;
            try
            {
                staff2 = new HourlyWage("Dean", "Andrewson", 150, 120);
            }
            catch (Exception e)
            {
                Console.WriteLine("Incorrect data. " + e.Message);
            }
            
            if (staff2 != null)
            {
                allEmp.Add(staff2);
            }
            Console.WriteLine("Done. Press any key.");
            Console.ReadKey();
            ShowMenu();
        }
        /// <summary>
        /// Вывести всю информацию
        /// </summary>
        static void ShowAll()
        {
            Console.Clear();
            foreach (StaffSalary o in allEmp)
            {
                Console.WriteLine(o);
                Console.WriteLine("------------------------------------------------");
            }
            Console.WriteLine("Done. Press any key.");
            Console.ReadKey();
            ShowMenu();
        }

        static int TryParseInt()
        {
            while (true)
            {
                try
                {
                    var parseable = Convert.ToInt32(Console.ReadLine());
                    return parseable;
                }
                catch
                {
                    Console.Write("Error. Please try again:");
                }
            }
        }

        static double TryParseDouble()
        {
            while (true)
            {
                try
                {
                    var parseable = Convert.ToDouble(Console.ReadLine());
                    return parseable;
                }
                catch
                {
                    Console.Write("Error. Please try again:");
                }
            }
        }
    }
}
