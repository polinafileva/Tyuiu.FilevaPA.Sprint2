namespace Tyuiu.FilevaPA.Sprint2.Task3.V10;
using Tyuiu.FilevaPA.Sprint2.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y     *");
        Console.WriteLine("* с использованием вложенных операторов if-else. Пользователь вводит     *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение      *");
        Console.WriteLine("* до трех знаков после запятой.                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        try
        {
            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            // Проверка на особые случаи (деление на ноль)
            if (x == 4)
            {
                Console.WriteLine("Ошибка: X не может быть равен 4 (деление на ноль)");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x);

            Console.WriteLine($"При X = {x}");
            Console.WriteLine($"Значение функции Y = {result}");

            // Вывод информации о выбранной ветке
            Console.WriteLine();
            Console.WriteLine("Использованная формула:");
            if (x > 0)
            {
                Console.WriteLine("y = x - ((x + 15) / (x - 4))^x");
            }
            else if (x == 0)
            {
                Console.WriteLine("y = x² + cos(x²) - 3");
            }
            else if (x > -14 && x < 0)
            {
                Console.WriteLine("y = (x² - sin(x²) + 2) / (5 + 1/x²)");
            }
            else if (x < -14)
            {
                Console.WriteLine("y = x + 10x - (1/x)");
            }
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