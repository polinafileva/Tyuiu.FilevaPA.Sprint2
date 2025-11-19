namespace Tyuiu.FilevaPA.Sprint2.Task6.V8;
using Tyuiu.FilevaPA.Sprint2.Task6.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
        Console.WriteLine("* Задание #6                                                           *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
        Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
        Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
        Console.WriteLine("* n (порядковый номер месяца) и m (число).                               *");
        Console.WriteLine("* По заданным n и m определить дату предыдущего дня                      *");
        Console.WriteLine("* (принять, что n и m не характеризуют 1 января).                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        try
        {
            Console.WriteLine("Введите номер месяца (n от 1 до 12):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (m):");
            int m = Convert.ToInt32(Console.ReadLine());

            // Проверка корректности ввода
            if (n < 1 || n > 12)
            {
                Console.WriteLine("Ошибка: месяц должен быть от 1 до 12");
                return;
            }

            if (m < 1 || m > 31)
            {
                Console.WriteLine("Ошибка: число должно быть от 1 до 31");
                return;
            }

            // Проверка что не 1 января
            if (n == 1 && m == 1)
            {
                Console.WriteLine("Ошибка: дата не должна быть 1 января");
                return;
            }

            // Проверка корректности даты
            bool isValidDate = CheckDate(n, m);
            if (!isValidDate)
            {
                Console.WriteLine("Ошибка: введена некорректная дата");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(n, m);

            Console.WriteLine($"Текущая дата: {m.ToString("D2")}.{n.ToString("D2")}.2024");
            Console.WriteLine($"Предыдущая дата: {result}");
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

    private static bool CheckDate(int month, int day)
    {
        if (day < 1) return false;

        return month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => day <= 31,
            4 or 6 or 9 or 11 => day <= 30,
            2 => day <= 28, // Февраль (не високосный)
            _ => false
        };
    }
}