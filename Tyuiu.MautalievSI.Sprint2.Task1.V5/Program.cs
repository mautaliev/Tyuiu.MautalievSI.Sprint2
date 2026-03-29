using System;
using Tyuiu.MautalievSI.Sprint2.Task1.V5.Lib;

// ЗАДАНИЕ
// Выполнить операции сравнения и логические операции
// и вывести результат в виде массива логических значений.

namespace Tyuiu.MautalievSI.Sprint2.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Мауталиев С. И. | НТм-24-1 | Задание #1 | Вариант #5";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Мауталиев С. И. | НТм-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выполнить операции сравнения и логические операции.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b, c, d;

            Console.WriteLine("Введите значение a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение c:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение d:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine($"({result[0]}, {result[1]}, {result[2]}, {result[3]}, {result[4]}, {result[5]})");

            Console.ReadKey();
        }
    }
}