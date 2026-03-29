using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task1.V5.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLogicOperations()
        {
            DataService ds = new DataService();

            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;

            bool[] wait = new bool[] { true, false, false, false, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}