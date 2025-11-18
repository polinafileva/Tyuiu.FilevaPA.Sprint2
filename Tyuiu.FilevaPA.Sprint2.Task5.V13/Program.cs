namespace Tyuiu.FilevaPA.Sprint2.Task5.V13;
using Tyuiu.FilevaPA.Sprint2.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Филева Полина Алексеевна. | ИСПБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #13                                                            *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПБ-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет      *");
        Console.WriteLine("* требуемое значение и возвращает результат.                              *");
        Console.WriteLine("* Для некоторого года характеризуется тремя натуральными числами:         *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
        Console.WriteLine("* По заданным g, m и n определите дату следующего дня.                   *");
        Console.WriteLine("* Заданный год считается високосным.                                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        try
        {
            Console.WriteLine("Введите год (g):");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц (m от 1 до 12):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            // Проверка корректности ввода
            if (m < 1 || m > 12)
            {
                Console.WriteLine("Ошибка: месяц должен быть от 1 до 12");
                return;
            }

            if (n < 1 || n > 31)
            {
                Console.WriteLine("Ошибка: число должно быть от 1 до 31");
                return;
            }

            // Проверка корректности даты
            bool isValidDate = CheckDate(g, m, n, ds.IsLeapYear(g));
            if (!isValidDate)
            {
                Console.WriteLine("Ошибка: введена некорректная дата");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine($"Текущая дата: {n}.{m}.{g}");
            Console.WriteLine($"Год високосный: {ds.IsLeapYear(g)}");
            Console.WriteLine($"Следующая дата: {result}");
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

    private static bool CheckDate(int year, int month, int day, bool isLeapYear)
    {
        if (day < 1) return false;

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return day <= 31;
            case 4:
            case 6:
            case 9:
            case 11:
                return day <= 30;
            case 2:
                return day <= (isLeapYear ? 29 : 28);
            default:
                return false; ;
        }
    }
}    