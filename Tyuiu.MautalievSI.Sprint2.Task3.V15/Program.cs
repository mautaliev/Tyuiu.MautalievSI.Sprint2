using System;
using Tyuiu.MautalievSI.Sprint2.Task3.V15.Lib;

// ЗАДАНИЕ
// Вычислить значение функции Y в зависимости от X с использованием if-else.
// Округлить результат до 3 знаков.

namespace Tyuiu.MautalievSI.Sprint2.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Мауталиев С. И. | НТм-24-1 | Задание #3 | Вариант #15";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Ветвления (if-else)                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции Y в зависимости от X.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x);

            Console.WriteLine("Y = " + result);

            Console.ReadKey();
        }
    }
}