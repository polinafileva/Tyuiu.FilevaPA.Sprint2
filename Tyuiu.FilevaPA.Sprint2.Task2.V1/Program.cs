namespace Tyuiu.FilevaPA.Sprint2.Task2.V1;
using Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры    *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
        Console.WriteLine("* области.                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        try
        {
            Console.WriteLine("Введите координату X (от 1 до 15):");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату Y (от 1 до 15):");
            int y = Convert.ToInt32(Console.ReadLine());

            // Проверка на выход за границы координатной сетки
            if (x < 1 || x > 15 || y < 1 || y > 15)
            {
                Console.WriteLine("Ошибка: координаты должны быть в диапазоне от 1 до 15");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine($"Точка с координатами ({x}, {y})");

            if (result)
            {
                Console.WriteLine("находится в заштрихованной области");
                Console.WriteLine("(прямоугольник: X от 5 до 10, Y от 5 до 10)");
            }
            else
            {
                Console.WriteLine("не находится в заштрихованной области");
            }

            // Вывод координатной сетки для наглядности
            Console.WriteLine();
            Console.WriteLine("Координатная сетка 15x15:");
            Console.WriteLine("Заштрихованная область: прямоугольник X[5-10], Y[5-10]");

            for (int row = 15; row >= 1; row--)
            {
                Console.Write($"{row,2} ");
                for (int col = 1; col <= 15; col++)
                {
                    if (col >= 5 && col <= 10 && row >= 5 && row <= 10)
                    {
                        Console.Write("■ ");
                    }
                    else if (col == x && row == y)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("   ");
            for (int col = 1; col <= 15; col++)
            {
                Console.Write($"{col % 10} ");
            }
            Console.WriteLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите целое число");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}