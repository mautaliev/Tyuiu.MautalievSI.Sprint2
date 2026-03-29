using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task3.V15.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            double x = 2;
            double wait = 11.000;

            double res = ds.Calculate(x);

            Assert.AreEqual(wait, res);
        }
    }
}