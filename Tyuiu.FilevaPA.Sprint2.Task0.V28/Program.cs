namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
        Console.WriteLine("**************************************************************************");

        int x = 111;
        int y = 735;

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"Ожидаемый результат: (False, False, False, False, False, False)");
        Console.WriteLine();

        // Тестируем разные варианты
        TestSequence(ds, x, y, "Basic", ds.GetCompareOperations);
        TestSequence(ds, x, y, "With Arithmetic", ds.GetCompareOperationsWithArithmetic);
        TestSequence(ds, x, y, "Strict", ds.GetCompareOperationsStrict);
        TestSequence(ds, x, y, "Final", ds.GetCompareOperationsFinal);
        TestSequence(ds, x, y, "Exact", ds.GetCompareOperationsExact);

        Console.ReadKey();
    }

    static void TestSequence(DataService ds, int x, int y, string methodName, Func<int, int, bool[]> method)
    {
        Console.WriteLine($"**************************************************************************");
        Console.WriteLine($"* МЕТОД: {methodName,-52} *");
        Console.WriteLine($"**************************************************************************");

        try
        {
            bool[] results = method(x, y);

            Console.WriteLine($"Результат: ({string.Join(", ", results)})");

            // Проверяем соответствие ожидаемому результату
            bool allFalse = results.All(r => r == false);
            Console.WriteLine($"Соответствие ожидаемому: {(allFalse ? "ДА" : "НЕТ")}");

            if (!allFalse)
            {
                Console.WriteLine("Ошибка в позициях:");
                for (int i = 0; i < results.Length; i++)
                {
                    if (results[i] != false)
                    {
                        Console.WriteLine($"  Позиция {i}: ожидалось False, получено {results[i]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine();
    }
}