using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryModel.SalaryTypes
{
    /// <summary>
    /// сотрудник с почасовой оплатой
    /// </summary>
    public class HourlyWage: StaffSalary
    {
        public HourlyWage()
        {

        }
        /// <summary>
        /// Конструктор, принимающий имя и фамилию
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        public HourlyWage(string firstname, string surname)
        {
            if (!(Validator.Validator.ValidateString(firstname) && Validator.Validator.ValidateString(surname)))
            {
                throw new ArgumentException();
            }
            this.Firstname = firstname;
            this.Surname = surname;
        }
        /// <summary>
        /// Конструктор, принимающий имя, фамилию, ставку за час, отработанное кол-во часов
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        /// <param name="hourPrice"></param>
        /// <param name="hoursWorked"></param>
        public HourlyWage(string firstname, string surname, double hourPrice, double hoursWorked)
        {
            if (!(Validator.Validator.ValidateString(firstname) && Validator.Validator.ValidateString(surname)))
            {
                throw new ArgumentException();
            }
            
            this.Firstname = firstname;
            this.Surname = surname;
            this.HourPrice = hourPrice;
            this.HoursWorked = hoursWorked;
        }
        /// <summary>
        /// Цена часа
        /// </summary>
        private double hourPrice;
        /// <summary>
        /// Property цены часа
        /// </summary>
        public double HourPrice
        {
            get { return hourPrice; }
            set 
            {
                if (!(Validator.Validator.ValidateNumber(value) 
                    && (value >= 0) && (value <= 1000)))
                {
                    throw new ArgumentException("Invalid hourPrice");
                }
                hourPrice = value; 
            }
        }
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private double hoursWorked;
        /// <summary>
        /// Property отработанных часов
        /// </summary>
        public double HoursWorked
        {
            get { return hoursWorked; }
            set 
            {
                if (!(Validator.Validator.ValidateNumber(value) 
                    && (value >= 80) && (value <= 300)))
                {
                    throw new ArgumentException("Invalid hoursWorked");
                }
                hoursWorked = value; 
            }
        }

        /// <summary>
        /// Расчет почасовой зарплаты
        /// </summary>
        /// <returns></returns>
        public override double GetSalaryValue()
        {
            return (hourPrice * hoursWorked);
        }
        /// <summary>
        /// Преобразование объекта в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Firstname + " " + Surname + " worked " + hoursWorked + " hours. One emp hour costs " + hourPrice + ". At mounth emp salary is " + GetSalaryValue() + "."; 
        }
    }
}
