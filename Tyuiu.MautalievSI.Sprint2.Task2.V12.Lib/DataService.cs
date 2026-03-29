using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MautalievSI.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((y == 3 || y == 4) && ((x >= 3 && x <= 5) || (x >= 9 && x <= 12)))
                res = true;
            else if (y == 5 && x >= 3 && x <= 12)
                res = true;
            else if ((y == 6 || y == 7) && x >= 3 && x <= 13)
                res = true;
            else if (y == 8 && x >= 6 && x <= 13)
                res = true;
            else if ((y == 9 || y == 10) && ((x >= 6 && x <= 7) || (x >= 11 && x <= 12)))
                res = true;
            else if (y == 11 && ((x >= 3 && x <= 7) || (x >= 11 && x <= 12)))
                res = true;
            else if (y == 12 && (x == 7 || (x >= 11 && x <= 12)))
                res = true;

            return res;
        }
    }
}