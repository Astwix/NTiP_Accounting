using System;
using NUnit.Framework;

namespace SalaryTests
{
    [TestFixture]
    public class HourlyWageTests
    {
        [TestCase("Алексей", "Волконский", TestName = "Hourly Wage 2 Params Constructor")]
        [Test]
        public void HourlyWageConstructor2Params(string firstname, string surname)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage(firstname, surname);
        }

        [TestCase("Алексей", "Волконский", 100, 100, TestName = "Hourly Wage 4 Params Constructor")]
        [Test]
        public void HourlyWageConstructor4Params(string firstname, string surname, double hp, double hw)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage(firstname, surname, hp, hw);
        }

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

        [TestCase(50, TestName = "Hourly Wage Set HourPrice")]
        [Test]
        public void HourlyWageHourPriceSet(double hourprice)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
            staff.HourPrice = hourprice;
            Assert.AreEqual(hourprice, staff.HourPrice);
        }

        [TestCase(200, TestName = "Hourly Wage Set HoursWorked")]
        [Test]
        public void HourlyWageHoursWorkedSet(double hourworked)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
            staff.HoursWorked = hourworked;
            Assert.AreEqual(hourworked, staff.HoursWorked);
        }

        [TestCase(-1, TestName = "(Negative) Hourly Wage Set HourseWorked")]
        [Test]
        public void NegativeHourlyWageHoursWorkedSet(double hours)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
                staff.HoursWorked = hours;
            });
        }

        [TestCase(-1, TestName = "(Negative) Hourly Wage Set HourPrice")]
        [Test]
        public void NegativeHourlyWageHourPriceSet(double hourprice)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage();
                staff.HourPrice = hourprice;
            });
        }

        [TestCase("Алексей", TestName = "Hourly Wage Get Firstname")]
        [Test]
        public void HourlyWageFirstnameGet(string firstname)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage("Алексей", "Волконский", 100, 100);
            Assert.AreEqual(firstname, staff.Firstname);
        }

        [TestCase("Волконский", TestName = "Hourly Wage Get Surname")]
        [Test]
        public void HourlyWageSurnameGet(string surname)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage("Алексей", "Волконский", 100, 100);
            Assert.AreEqual(surname, staff.Surname);
        }

        [TestCase(100, TestName = "Hourly Wage Get HourPrice")]
        [Test]
        public void HourlyWageHourPriceGet(double hourprice)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage("Алексей", "Волконский", 100, 100);
            Assert.AreEqual(hourprice, staff.HourPrice);
        }

        [TestCase(200, TestName = "Hourly Wage Get HoursWorked")]
        [Test]
        public void HourlyWageHoursWorkedGet(double hourworked)
        {
            SalaryModel.SalaryTypes.HourlyWage staff = new SalaryModel.SalaryTypes.HourlyWage("Алексей", "Волконский", 100, 200);
            Assert.AreEqual(hourworked, staff.HoursWorked);
        }
    }
}
