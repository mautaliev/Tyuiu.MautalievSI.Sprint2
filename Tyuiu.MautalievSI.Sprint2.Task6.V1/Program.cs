using System;
using Tyuiu.MautalievSI.Sprint2.Task6.V1.Lib;

namespace Tyuiu.MautalievSI.Sprint2.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Мауталиев С.И. | Группа ... | Задание #6 | Вариант #1";

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #2                                               *");
            Console.WriteLine("* Тема: Оператор switch                                   *");
            Console.WriteLine("* Задание #6                                              *");
            Console.WriteLine("* Вариант #1                                              *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* По номеру месяца определить количество дней             *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");

            Console.WriteLine("Введите номер месяца:");
            int value = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");

            int result = ds.FindMonthDaysCount(value);

            if (result == -1)
                Console.WriteLine("Некорректный номер месяца");
            else
                Console.WriteLine(result);

            Console.WriteLine("***********************************************************");
            Console.ReadKey();
        }
    }
}