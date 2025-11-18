namespace Tyuiu.FilevaPA.Sprint2.Task4.V25;
using Tyuiu.FilevaPA.Sprint2.Task4.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с             *");
        Console.WriteLine("* использованием тернарного оператора. Пользователь вводит значение      *");
        Console.WriteLine("* переменных X, Y с клавиатуры. Ответ округлить до 3 знаков после запятой.*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        try
        {
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            // Проверка на особые случаи (деление на ноль)
            if (x == 0)
            {
                Console.WriteLine("Ошибка: X не может быть равен 0 (деление на ноль)");
                return;
            }

            if (y == -2)
            {
                Console.WriteLine("Ошибка: Y не может быть равен -2 (деление на ноль)");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);

            Console.WriteLine($"При X = {x}, Y = {y}");

            // Проверяем какое условие выполнилось
            bool condition = (x - 20 * 2 < y + 4);
            Console.WriteLine($"Условие (X - 40 < Y + 4): {condition}");

            if (condition)
            {
                Console.WriteLine("Использована формула: z = (1 + 2/X²)^Y");
            }
            else
            {
                Console.WriteLine("Использована формула: z = Y + ((X + 1)/(Y + 2))^X");
            }

            Console.WriteLine($"Результат Z = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите числовое значение");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}