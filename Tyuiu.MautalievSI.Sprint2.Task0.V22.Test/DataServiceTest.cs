using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MautalievSI.Sprint2.Task0.V22.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCompareOperations()
        {
            DataService ds = new DataService();

            int x = 3105;
            int y = 77;

            bool[] wait = new bool[] { false, true, true, true, true, false };
            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}