namespace Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;
using Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                    *");
        Console.WriteLine("* Задание #1                                                        *");
        Console.WriteLine("* Вариант #7                                                        *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
        Console.WriteLine("* которая вернет логическую последовательность:                           *");
        Console.WriteLine("* (True, False, False, False, True, False, False)                         *");
        Console.WriteLine("* при a = 195, b = 16, c = 14, d = 45                                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        int a = 195;
        int b = 16;
        int c = 14;
        int d = 45;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"d = {d}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool[] results = ds.GetLogicOperations(a, b, c, d);

        Console.WriteLine("Логическая последовательность:");
        Console.WriteLine($"({string.Join(", ", results)})");

        Console.WriteLine();
        Console.WriteLine("Подробные результаты:");
        Console.WriteLine($"a > (b + c)           = {results[0]}");      // True
        Console.WriteLine($"b <= c                = {results[1]}");      // False
        Console.WriteLine($"a == (b * 12)         = {results[2]}");      // False
        Console.WriteLine($"(d / 9) >= c          = {results[3]}");      // False
        Console.WriteLine($"c < d                 = {results[4]}");      // True
        Console.WriteLine($"(a % 19) == 0         = {results[5]}");      // False
        Console.WriteLine($"(b + c) == a          = {results[6]}");      // False

        // Проверка соответствия ожидаемому результату
        bool[] expected = { true, false, false, false, true, false, false };
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