using System;
using Tyuiu.MautalievSI.Sprint2.Task5.V11.Lib;

// ЗАДАНИЕ
// Определить дату следующего дня по заданной дате (год не високосный)

namespace Tyuiu.MautalievSI.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Мауталиев С. И. | НТм-24-1 | Задание #5 | Вариант #11";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданной дате определить дату следующего дня.                         *");
            Console.WriteLine("* Год не является високосным.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g, m, n;

            Console.WriteLine("Введите год:");
            g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("Следующий день: " + result);

            Console.ReadKey();
        }
    }
}