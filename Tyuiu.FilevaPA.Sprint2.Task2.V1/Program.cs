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
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Paint                                                                  *");


        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");


        Console.WriteLine("Введите x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y");
        int y = Convert.ToInt32(Console.ReadLine());
        bool res = ds.CheckDotInShadedArea(x, y);



        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");


        if (res)
        {
            Console.WriteLine("Точка есть в области");
        }
        else
        {
            Console.WriteLine("Точки нет в области");
        }


        Console.ReadKey();
    }
}