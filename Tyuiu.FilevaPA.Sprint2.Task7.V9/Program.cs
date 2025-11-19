namespace Tyuiu.FilevaPA.Sprint2.Task7.V9;
using Tyuiu.FilevaPA.Sprint2.Task7.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 Выполнила:Филева Полина Алексеевна| ИСПб-25-1";
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #2                                                              *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #9                                                             *");
        Console.WriteLine("* Выполнила: Филева Полина Алексеевна | ИСПб-25-1                          *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные          *");
        Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами *");
        Console.WriteLine("* X,Y в заштрихованной области. Область ограничена сверху линией y=0.5, *");
        Console.WriteLine("* снизу синусоидой y=sin(x)                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine("Введите координату X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Точка с координатами (" + x + ", " + y + ") " +
                         (res ? "находится" : "не находится") + " в заштрихованной области");

        Console.ReadKey();

    }
}