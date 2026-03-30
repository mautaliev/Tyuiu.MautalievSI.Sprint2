using System;
using Tyuiu.MautalievSI.Sprint2.Task7.V8.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Мауталиев С.И. | Группа ... | Задание #7 | Вариант #8";

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Условные операторы                                *");
            Console.WriteLine("* Задание #7                                              *");
            Console.WriteLine("* Вариант #8                                              *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Проверить, принадлежит ли точка заштрихованной области  *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine(result ? "Точка принадлежит области" : "Точка не принадлежит области");

            Console.WriteLine("***********************************************************");
            Console.ReadKey();
        }
    }
}