namespace Tyuiu.FilevaPA.Sprint2.Task4.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task4V25
{
    public double Calculate(double x, double y)
    {
        // Тернарный оператор
        double result = (x - 20 * 2 < y + 4)
            ? Math.Pow(1 + 2 / Math.Pow(x, 2), y)  // Если условие истинно
            : y + Math.Pow((x + 1) / (y + 2), x);  // Если условие ложно

        return Math.Round(result, 3);
    }
}
