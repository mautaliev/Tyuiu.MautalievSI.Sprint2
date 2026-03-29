using System;
using Tyuiu.MautalievSI.Sprint2.Task0.V22.Lib;

// ЗАДАНИЕ
// Выполнить операции сравнения и вернуть массив логических значений.

namespace Tyuiu.MautalievSI.Sprint2.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Мауталиев С. И. | НТм-24-1 | Задание #0 | Вариант #22";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выполнить операции сравнения и вывести результат в виде массива.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine($"({result[0]}, {result[1]}, {result[2]}, {result[3]}, {result[4]}, {result[5]})");

            Console.ReadKey();
        }
    }
}