using System;
using Tyuiu.MautalievSI.Sprint2.Task3.V16.Lib;

// ЗАДАНИЕ
// Вычислить значение выражения с использованием тернарного оператора.
// Если 2*x <= 2*y → z = (1 + 1/y^2)^x
// иначе z = y - (1/x^2)
// Результат округлить до 3 знаков.

namespace Tyuiu.MautalievSI.Sprint2.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Мауталиев С. И. | НТм-24-1 | Задание #4 | Вариант #16";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Если 2*x <= 2*y, то z = (1 + 1/y^2)^x, иначе z = y - (1/x^2)            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);

            Console.WriteLine("z = " + result);

            Console.ReadKey();
        }
    }
}