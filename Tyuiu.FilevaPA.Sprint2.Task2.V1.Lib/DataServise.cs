namespace Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataServise : ISprint2Task2V1
{

public bool CheckDotInShadedArea(int x, int y)
    {
        // Предположим, что заштрихованы квадраты по шахматному паттерну
        // или определенные области. Можно настроить под конкретный рисунок

        // Вариант 1: Шахматная доска (черные клетки)
        bool isBlackSquare = ((x + y) % 2) == 0;

        // Вариант 2: Определенные заштрихованные блоки
        // Например, квадраты в углах 3x3
        bool inTopLeft = (x >= 1 && x <= 3 && y >= 1 && y <= 3);
        bool inTopRight = (x >= 13 && x <= 15 && y >= 1 && y <= 3);
        bool inBottomLeft = (x >= 1 && x <= 3 && y >= 13 && y <= 15);
        bool inBottomRight = (x >= 13 && x <= 15 && y >= 13 && y <= 15);
        bool inCenter = (x >= 7 && x <= 9 && y >= 7 && y <= 9);

        // Объединяем все заштрихованные области
        bool inShadedArea = inTopLeft || inTopRight || inBottomLeft || inBottomRight || inCenter;

        return inShadedArea;
    }
}
