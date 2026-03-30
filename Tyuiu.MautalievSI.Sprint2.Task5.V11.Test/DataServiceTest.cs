using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task5.V11.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 9;
            int n = 8;

            string wait = "09.09.2023";
            string res = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(wait, res);
        }
    }
}