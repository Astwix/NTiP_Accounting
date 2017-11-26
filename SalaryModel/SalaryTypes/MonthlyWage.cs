using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryModel.SalaryTypes
{
    /// <summary>
    /// Сотрудник с месячной з.п (окладом) 
    /// </summary>
    public class MonthlyWage: StaffSalary
    {
        public MonthlyWage()
        {

        }
        /// <summary>
        /// Конструктор, принимающий имя и фамилию
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        public MonthlyWage(string firstname, string surname)
        {
            if (!(Validator.Validator.ValidateString(firstname) && Validator.Validator.ValidateString(surname)))
            {
                throw new ArgumentException();
            }
            this.Firstname = firstname;
            this.Surname = surname;
        }

        /// <summary>
        /// Конструктор, принимающий имя, фамилию, оклад, ставку и премию
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="surname"></param>
        /// <param name="reward"></param>
        /// <param name="rate"></param>
        /// <param name="bounty"></param>
        public MonthlyWage(string firstname, string surname, double reward, double rate, double bounty)
        {
            if (!(Validator.Validator.ValidateString(firstname) && Validator.Validator.ValidateString(surname)))
            {
                throw new ArgumentException();
            }
            
            this.Firstname = firstname;
            this.Surname = surname;
            this.Reward = reward;
            this.Rate = rate;
            this.Bounty = bounty;
        }

        /// <summary>
        /// Оклад
        /// </summary>
        private double _reward;

        /// <summary>
        /// Property оклада
        /// </summary>
        public double Reward
        {
            get { return _reward; }
            set 
            {
                if (!(Validator.Validator.ValidateNumber(value) && (value > 0)))
                {
                    throw new ArgumentException("Invalid reward");
                }
                _reward = value; 
            }
        }

        /// <summary>
        /// Ставка
        /// </summary>
        private double rate;

        /// <summary>
        /// Property ставки
        /// </summary>
        public double Rate
        {
            get { return rate; }
            set 
            {
                if (!(Validator.Validator.ValidateNumber(value) && (value > 0)))
                {
                    throw new ArgumentException("Invalid rate");
                }
                rate = value; 
            }
        }

        /// <summary>
        /// Премия
        /// </summary>
        private double bounty;
        /// <summary>
        /// Property премии
        /// </summary>
        public double Bounty
        {
            get { return bounty; }
            set 
            { 
                if (!(Validator.Validator.ValidateNumber(value) && (value >= 0)))
                {
                    throw new ArgumentException("Invalid bounty");
                }
                bounty = value; 
            }
        }
        /// <summary>
        /// Расчет месячной зарплаты
        /// </summary>
        /// <returns></returns>
        public override double GetSalaryValue()
        {
            return ((_reward * rate) + bounty);
        }
        /// <summary>
        /// Преобразование объекта в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Firstname + " " + Surname + " monthly reward is " + _reward+ ". Employee works on " + rate + " rate. With bounty " + bounty + ". Mounth emp salary is " + GetSalaryValue() + ".";
        }
    }
}
