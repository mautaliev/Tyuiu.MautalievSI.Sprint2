using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task3.V16.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            double wait = 1.235;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}