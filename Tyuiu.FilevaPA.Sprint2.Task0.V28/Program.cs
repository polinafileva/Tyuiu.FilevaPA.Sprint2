namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                            *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу для операций сравнения (арифметических выражений),   *");
        Console.WriteLine("* которая возвращает логическую последовательность (массив):              *");
        Console.WriteLine("* (False, False, False, False, False, False) при x = 111, y = 735        *");
        Console.WriteLine("* 6 операций: <, >, <=, >=, ==, !=                                       *");
        Console.WriteLine("* Последовательность операций не должна нарушаться                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        Console.Write("Введите значение X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool[] results = ds.GetCompareOperations(x, y);

        Console.WriteLine($"При x = {x}, y = {y}:");
        Console.WriteLine($"x + 15 = {x + 15}");
        Console.WriteLine();
        Console.WriteLine("Результаты операций сравнения:");
        Console.WriteLine($"1. (x + 15) < y  = {results[0]}");
        Console.WriteLine($"2. (x + 15) > y  = {results[1]}");
        Console.WriteLine($"3. (x + 15) <= y = {results[2]}");
        Console.WriteLine($"4. (x + 15) >= y = {results[3]}");
        Console.WriteLine($"5. (x + 15) == y = {results[4]}");
        Console.WriteLine($"6. (x + 15) != y = {results[5]}");

        Console.WriteLine();
        Console.WriteLine("Логическая последовательность:");
        Console.Write("(");
        for (int i = 0; i < results.Length; i++)
        {
            Console.Write(results[i]);
            if (i < results.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(")");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ПРОВЕРКА ДЛЯ x = 111, y = 735:                                         *");
        Console.WriteLine("***************************************************************************");

        // Автоматическая проверка для заданных значений
        if (x == 111 && y == 735)
        {
            bool allFalse = true;
            foreach (bool result in results)
            {
                if (result)
                {
                    allFalse = false;
                    break;
                }
            }

            if (allFalse)
            {
                Console.WriteLine("✓ УСПЕХ: Все операции вернули False как и требовалось!");
            }
            else
            {
                Console.WriteLine("✗ ОШИБКА: Не все операции вернули False!");
            }
        }

        Console.ReadKey();
    }
}