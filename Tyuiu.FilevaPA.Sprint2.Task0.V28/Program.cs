namespace Tyuiu.FilevaPA.Sprint2.Task0.V28;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                       *");
        Console.WriteLine("* Тема: Операции сравнения и логические операции                         *");
        Console.WriteLine("* Задание #0                                                          *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений, которая вернет               *");
        Console.WriteLine("* логическую последовательность (False, False, False, False, False, False)*");
        Console.WriteLine("* при x = 111, y = 735                                                    *");
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
        Console.Write("(");
        for (int i = 0; i < results.Length; i++)
        {
            Console.Write(results[i]);
            if (i < results.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(")");

        Console.ReadKey();
    }
}