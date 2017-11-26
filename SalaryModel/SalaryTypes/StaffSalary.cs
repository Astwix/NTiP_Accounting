using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryModel.SalaryTypes
{
    /// <summary>
    /// Абстрактный класс сотрудник
    /// </summary>
    public abstract class StaffSalary
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Расчет зарплаты
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalaryValue();
    }
}