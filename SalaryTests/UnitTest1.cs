using System;
using NUnit.Framework;

namespace SalaryTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("Алексей", TestName = "Hourly Wage Set Firstname")]
        [Test]
        public void HourlyWageFirstnameSet(string firstname)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
            staff.Firstname = firstname;
            Assert.AreEqual(firstname, staff.Firstname);
        }

        [TestCase("Волконский", TestName = "Hourly Wage Set Surname")]
        [Test]
        public void HourlyWageSurnameSet(string surname)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
            staff.Surname = surname;
            Assert.AreEqual(surname, staff.Surname);
        }

        [TestCase(-1, TestName = "Negative Hourly Wage Set HourseWorked")]
        [Test]
        public void NegativeHourlyWageHorseWorkedSet(double hours)
        {
            Assert.Throws<System.ArgumentException>(()=>{
                SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
                staff.HoursWorked = hours; 
            });
        }
    }
}
