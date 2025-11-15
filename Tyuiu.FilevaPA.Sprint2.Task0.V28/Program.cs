namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                       *");
        Console.WriteLine("* Задание #0                                                           *");
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

        int x = 111;
        int y = 735;

        Console.WriteLine($"X = {x}");
        Console.WriteLine($"Y = {y}");

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

        Console.WriteLine();
        Console.WriteLine("Полная последовательность:");
        Console.WriteLine($"({string.Join(", ", results)})");

        // Проверка соответствия ожидаемому результату
        bool[] expected = { false, false, false, false, false, false };
        bool isCorrect = true;

        for (int i = 0; i < results.Length; i++)
        {
            if (results[i] != expected[i])
            {
                isCorrect = false;
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Ожидаемая последовательность: ({string.Join(", ", expected)})");
        Console.WriteLine($"Результат корректный: {isCorrect}");

        Console.ReadKey();
    }
}