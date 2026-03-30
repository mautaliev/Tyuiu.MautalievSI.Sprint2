using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MautalievSI.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = 0;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                case 2:
                    daysInMonth = 28;
                    break;
            }

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;

                if (m < 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    g++;
                }
            }

            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}