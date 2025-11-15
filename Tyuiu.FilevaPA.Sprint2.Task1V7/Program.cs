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
        Console.WriteLine("* (True, False, False, True, False, True, False)                          *");
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
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"[{i}] = {results[i]}");
        }

        Console.WriteLine();
        Console.WriteLine("Полная последовательность:");
        Console.WriteLine($"({string.Join(", ", results)})");

        // Проверка соответствия ожидаемому результату
        bool[] expected = { true, false, false, true, false, true, false };
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