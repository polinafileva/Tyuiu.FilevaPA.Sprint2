namespace Tyuiu.FilevaPA.Sprint2.Task2.V1;
   using Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                            *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
        Console.WriteLine("* области. Сетка 15x15.                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        try
        {
            Console.Write("Введите координату X (1-15): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y (1-15): ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine($"Координаты точки: X = {x}, Y = {y}");
            Console.WriteLine($"Точка находится в заштрихованной области: {result}");

            if (result)
            {
                Console.WriteLine("Точка находится в заштрихованной области (черный квадрат)");
            }
            else
            {
                Console.WriteLine("Точка НЕ находится в заштрихованной области");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите целые числа");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}