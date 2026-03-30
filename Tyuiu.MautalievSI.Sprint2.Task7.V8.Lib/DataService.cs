using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MautalievSI.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return y >= 0 && y <= 4 && x >= Math.Sqrt(y);
        }
    }
}