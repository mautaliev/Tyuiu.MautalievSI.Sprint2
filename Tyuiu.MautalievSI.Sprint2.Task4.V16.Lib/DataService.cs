using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MautalievSI.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task4V16
    {
        public double Calculate(double x, double y)
        {
            double z = (2 * x <= 2 * y)
                ? Math.Pow(1 + 1 / (y * y), x)
                : y - 1 / (x * x);

            return Math.Round(z, 3);
        }
    }
}