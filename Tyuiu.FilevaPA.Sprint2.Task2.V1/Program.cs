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

            // Проверка допустимости координат
            if (x < 1 || x > 15 || y < 1 || y > 15)
            {
                Console.WriteLine("Ошибка: координаты должны быть в диапазоне от 1 до 15");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine($"Координаты точки: X={x}, Y={y}");
            Console.WriteLine($"Точка находится в заштрихованной области: {result}");

            // Дополнительная информация
            Console.WriteLine();
            Console.WriteLine("Заштрихованные области:");
            Console.WriteLine("- Верхний левый угол (1-3, 1-3)");
            Console.WriteLine("- Верхний правый угол (13-15, 1-3)");
            Console.WriteLine("- Нижний левый угол (1-3, 13-15)");
            Console.WriteLine("- Нижний правый угол (13-15, 13-15)");
            Console.WriteLine("- Центр (7-9, 7-9)");
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