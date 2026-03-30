using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task7.V8.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckPointInsideArea1()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(3, 2);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckPointInsideArea2()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(2, 4);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckPointOutsideArea1()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(1, 2);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void CheckPointOutsideArea2()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(3, 5);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void CheckPointOnBorder()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(2, 4);
            Assert.AreEqual(true, res);
        }
    }
}