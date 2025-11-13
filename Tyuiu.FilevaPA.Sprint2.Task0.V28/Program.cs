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

        Console.Write("Введите X: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите Y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool[] results = ds.GetCompareOperations(x, y);

        Console.WriteLine($"X = {x}, Y = {y}");
        Console.WriteLine($"X + 15 = {x + 15}");
        Console.WriteLine();
        Console.WriteLine("Результаты сравнений:");
        Console.WriteLine($"(X + 15) < Y  = {results[0]}");
        Console.WriteLine($"(X + 15) > Y  = {results[1]}");
        Console.WriteLine($"(X + 15) <= Y = {results[2]}");
        Console.WriteLine($"(X + 15) >= Y = {results[3]}");
        Console.WriteLine($"(X + 15) == Y = {results[4]}");
        Console.WriteLine($"(X + 15) != Y = {results[5]}");

        Console.ReadKey();
    }
}