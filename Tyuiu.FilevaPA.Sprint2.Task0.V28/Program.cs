namespace Tyuiu.FilevaPA.Sprint2.Task0.V28;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                       *");
        Console.WriteLine("* Тема: Операции сравнения и логические операции                         *");
        Console.WriteLine("* Задание #0                                                          *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,   *");
        Console.WriteLine("* которая вернет логическую последовательность (False, False, False,     *");
        Console.WriteLine("* False, False, False) при x = 111, y = 735                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 111;
        int y = 735;

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        bool[] results = ds.GetCompareOperations(x, y);

        Console.WriteLine("Логическая последовательность:");
        PrintBoolArray(results);

        // Детальный вывод операций
        Console.WriteLine("\nДетальный расчет операций:");
        Console.WriteLine("1. x == y                      → 111 == 735    → " + (x == y));
        Console.WriteLine("2. (x + 100) == (y - 500)     → 211 == 235    → " + ((x + 100) == (y - 500)));
        Console.WriteLine("3. (x * 10) < y               → 1110 < 735    → " + ((x * 10) < y));
        Console.WriteLine("4. (y / 10) > x               → 73 > 111      → " + ((y / 10) > x));
        Console.WriteLine("5. x <= (x - 50)              → 111 <= 61     → " + (x <= (x - 50)));
        Console.WriteLine("6. y >= (y + 10)              → 735 >= 745    → " + (y >= (y + 10)));

        Console.ReadKey();
    }

    private static void PrintBoolArray(bool[] array)
    {
        Console.Write("(");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(")");
    }
}