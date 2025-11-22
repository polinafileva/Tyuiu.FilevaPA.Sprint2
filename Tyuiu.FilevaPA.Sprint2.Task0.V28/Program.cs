namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ТЕСТИРОВАНИЕ ПОСЛЕДОВАТЕЛЬНОСТИ ОПЕРАЦИЙ                             *");
        Console.WriteLine("**************************************************************************");

        int x = 111;
        int y = 735;

        Console.WriteLine($"x = {x}, y = {y}");
        Console.WriteLine($"Ожидаемый результат: [false, false, false, false, false, false]");
        Console.WriteLine();

        bool[] results = ds.GetCompareOperations(x, y);

        Console.WriteLine($"Полученный результат: [{string.Join(", ", results.Select(r => r.ToString().ToLower()))}]");

        // Проверяем каждую операцию
        Console.WriteLine("\nДетальная проверка:");
        for (int i = 0; i < results.Length; i++)
        {
            string status = results[i] == false ? "✓" : "✗";
            Console.WriteLine($"Операция {i + 1}: {results[i]} {status}");
        }

        bool allCorrect = results.All(r => r == false);
        Console.WriteLine($"\nВсе операции корректны: {allCorrect}");

        Console.ReadKey();
    }
}