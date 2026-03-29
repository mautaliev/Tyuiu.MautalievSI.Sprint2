using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task2.V12.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea_ValidPoint_ReturnsTrue()
        {
            DataService ds = new DataService();

            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}