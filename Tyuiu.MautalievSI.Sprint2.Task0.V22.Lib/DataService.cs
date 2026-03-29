using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MautalievSI.Sprint2.Task0.V22.Lib
{
    public class DataService : ISprint2Task0V22
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x == y,
                x != y,
                x % y < y,
                x > y,
                x % y <= y,
                x >= y * y
            };
        }
    }
}