namespace Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task2V1



{
    public bool CheckDotInShadedArea(int x, int y)
    {
        // Вариант 1: Прямоугольник в центре (от 5 до 10 по X, от 5 до 10 по Y)
        bool inRectangle = (x >= 5) && (x <= 10) && (y >= 5) && (y <= 10);

        // Вариант 2: Треугольник (нижний левый)
        bool inTriangle = (x >= 1) && (y >= 1) && (x + y <= 16);

        // Вариант 3: Круг с центром в (8,8) радиусом 4
        double distance = Math.Sqrt(Math.Pow(x - 8, 2) + Math.Pow(y - 8, 2));
        bool inCircle = distance <= 4;

        // Выберите нужную фигуру, раскомментировав соответствующую строку:
        return inRectangle;   // Для прямоугольника
                              // return inTriangle; // Для треугольника  
                              // return inCircle;   // Для круга
    }
}
