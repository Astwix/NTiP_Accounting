using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryModel.Validator
{
    /// <summary>
    /// Класс для проверки параметров
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Проверка на string (Строка)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Проверка на double (вещественное число)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateNumber(double value)
        {
            if (value == 0) return true;
            if (double.IsInfinity(value) || double.IsNaN(value)
            || value <= double.MinValue || value >= double.MaxValue
            || value <= default(double)
            )
            {
                return false;
            }

            return true;
        }
    }
}
