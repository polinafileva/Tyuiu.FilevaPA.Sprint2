namespace Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
using Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataServise : ISprint2Task2V1
{

public bool CheckDotInShadedArea(int x, int y)
    {
        // Проверяем, что координаты в пределах сетки 15x15
        if (x < 1 || x > 15 || y < 1 || y > 15)
        {
            return false;
        }

        // Определяем заштрихованные области (черные квадраты)
        // Вариант 1: Квадраты по углам и в центре
        bool inTopLeft = (x >= 1 && x <= 3) && (y >= 1 && y <= 3);
        bool inTopRight = (x >= 13 && x <= 15) && (y >= 1 && y <= 3);
        bool inBottomLeft = (x >= 1 && x <= 3) && (y >= 13 && y <= 15);
        bool inBottomRight = (x >= 13 && x <= 15) && (y >= 13 && y <= 15);
        bool inCenter = (x >= 7 && x <= 9) && (y >= 7 && y <= 9);

        // Объединяем все заштрихованные области
        bool result = inTopLeft || inTopRight || inBottomLeft || inBottomRight || inCenter;

        return result;
    }
}
