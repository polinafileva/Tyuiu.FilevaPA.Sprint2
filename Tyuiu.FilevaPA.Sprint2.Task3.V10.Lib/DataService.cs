namespace Tyuiu.FilevaPA.Sprint2.Task3.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task3V10
{
    public double Calculate(double x)
    {
        double y = 0;

        if (x > 0)
        {
            // y = x - ((x + 15) / (x - 4))^x
            double baseValue = (x + 15) / (x - 4);
            y = x - Math.Pow(baseValue, x);
        }
        else if (x == 0)
        {
            // y = x² + cos(x²) - 3
            y = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 3;
        }
        else if (x > -14 && x < 0)
        {
            // y = (x² - sin(x²) + 2) / (5 + 1/x²)
            double numerator = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2;
            double denominator = 5 + 1 / Math.Pow(x, 2);
            y = numerator / denominator;
        }
        else if (x < -14)
        {
            // y = x + 10x - (1/x)
            y = x + 10 * x - (1 / x);
        }

        return Math.Round(y, 3);
    }
}
