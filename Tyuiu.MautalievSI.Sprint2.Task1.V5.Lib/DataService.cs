using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MautalievSI.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[]
            {
                (a + b) == (a + b),
                (a + b) != (a + b),
                (a + b) < (c + d),
                (c + d) > (a + b),
                (a + b) <= (a + b),
                (c + d) >= (a + b)
            };
        }
    }
}