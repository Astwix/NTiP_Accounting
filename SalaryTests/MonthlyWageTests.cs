using System;
using NUnit.Framework;

namespace SalaryTests
{
    [TestFixture]
    public class MonthlyWageTests
    {
        [TestCase("Алексей", "Волконский", TestName = "Monthly Wage 2 Params Constructor")]
        [Test]
        public void MonthlyWageConstructor2Params(string firstname, string surname)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage(firstname, surname);
        }

        [TestCase("Алексей", "Волконский", 10000, 2, 5000, TestName = "Monthly Wage 5 Params Constructor")]
        [Test]
        public void MonthlyWageConstructor5Params(string firstname, string surname, double rew, double rate, double bounty)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage(firstname, surname, rew, rate, bounty);
        }

        [TestCase("Алексей", TestName = "Monthly Wage Set Firstname")]
        [Test]
        public void MonthlyWageFirstnameSet(string firstname)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
            staff.Firstname = firstname;
            Assert.AreEqual(firstname, staff.Firstname);
        }

        [TestCase("Волконский", TestName = "Monthly Wage Set Surname")]
        [Test]
        public void MonthlyWageSurnameSet(string surname)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
            staff.Surname = surname;
            Assert.AreEqual(surname, staff.Surname);
        }

        [TestCase(10, TestName = "Monthly Wage Set Bounty")]
        [Test]
        public void MonthlyWageBountySet(double bounty)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
            staff.Bounty = bounty;
            Assert.AreEqual(bounty, staff.Bounty);
        }

        [TestCase(2, TestName = "Monthly Wage Set Rate")]
        [Test]
        public void MonthlyWageRateSet(double rate)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
            staff.Rate = rate;
            Assert.AreEqual(rate, staff.Rate);
        }

        [TestCase(10000, TestName = "Monthly Wage Set Reward")]
        [Test]
        public void MonthlyWageRewardSet(double rew)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
            staff.Reward = rew;
            Assert.AreEqual(rew, staff.Reward);
        }

        [TestCase(-1, TestName = "(Negative) Monthly Wage Set Bounty")]
        [Test]
        public void NegativeMonthlyWageBountySet(double bounty)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
                staff.Bounty = bounty;
            });
        }

        [TestCase(-1, TestName = "(Negative) Monthly Wage Set Rate")]
        [Test]
        public void NegativeMonthlyWageRateSet(double rate)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
                staff.Rate = rate;
            });
        }

        [TestCase(-1, TestName = "(Negative) Monthly Wage Set Reward")]
        [Test]
        public void NegativeMonthlyWageRewardSet(double rew)
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage();
                staff.Reward = rew;
            });
        }

        [TestCase(10000, TestName = "Monthly Wage Get Reward")]
        [Test]
        public void MonthlyWageRewardGet(double rew)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage("Алексей", "Волконский", 10000, 2, 5000);
            Assert.AreEqual(rew, staff.Reward);
        }

        [TestCase(2, TestName = "Monthly Wage Get Rate")]
        [Test]
        public void MonthlyWageRateGet(double rate)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage("Алексей", "Волконский", 10000, 2, 5000);
            Assert.AreEqual(rate, staff.Rate);
        }

        [TestCase(500, TestName = "Monthly Wage Get Bounty")]
        [Test]
        public void MonthlyWageBountyGet(double bounty)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage("Алексей", "Волконский", 10000, 2, 500);
            Assert.AreEqual(bounty, staff.Bounty);
        }

        [TestCase("Алексей", TestName = "Monthly Wage Get Firstname")]
        [Test]
        public void MonthlyWageFirstnameGet(string firstname)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage("Алексей", "Волконский", 10000, 2, 500);
            Assert.AreEqual(firstname, staff.Firstname);
        }

        [TestCase("Волконский", TestName = "Monthly Wage Get Surname")]
        [Test]
        public void MonthlyWageSurnameGet(string surname)
        {
            SalaryModel.SalaryTypes.MonthlyWage staff = new SalaryModel.SalaryTypes.MonthlyWage("Алексей", "Волконский", 10000, 2, 500);
            Assert.AreEqual(surname, staff.Surname);
        }
    }
}
