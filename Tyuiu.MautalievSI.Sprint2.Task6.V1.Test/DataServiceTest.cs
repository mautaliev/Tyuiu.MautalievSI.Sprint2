using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task6.V1.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckJanuary()
        {
            DataService ds = new DataService();
            int res = ds.FindMonthDaysCount(1);
            Assert.AreEqual(31, res);
        }

        [TestMethod]
        public void CheckFebruary()
        {
            DataService ds = new DataService();
            int res = ds.FindMonthDaysCount(2);
            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void CheckApril()
        {
            DataService ds = new DataService();
            int res = ds.FindMonthDaysCount(4);
            Assert.AreEqual(30, res);
        }

        [TestMethod]
        public void CheckDecember()
        {
            DataService ds = new DataService();
            int res = ds.FindMonthDaysCount(12);
            Assert.AreEqual(31, res);
        }

        [TestMethod]
        public void CheckInvalidMonth()
        {
            DataService ds = new DataService();
            int res = ds.FindMonthDaysCount(13);
            Assert.AreEqual(-1, res);
        }
    }
}