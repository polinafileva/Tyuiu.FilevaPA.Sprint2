namespace Tyuiu.FilevaPA.Sprint2.Task3.V10.Test;
using Tyuiu.FilevaPA.Sprint2.Task3.V10.Lib;


[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate_XEqualToZero()
    {
        DataService ds = new DataService();
        double x = 0;
        double result = ds.Calculate(x);
        double expected = -1.0; // Ожидаемое значение
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_XGreaterThanZero()
    {
        DataService ds = new DataService();
        double x = 5;
        double result = ds.Calculate(x);
        double wait = 5 - System.Math.Pow((5 + 15) / (5 - 4), 5);
        wait = System.Math.Round(wait, 3);
        Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void ValidCalculate_XBetweenMinus14AndZero()
    {
        DataService ds = new DataService();
        double x = -5;
        double result = ds.Calculate(x);
        double numerator = System.Math.Pow(-5, 2) - System.Math.Sin(System.Math.Pow(-5, 2)) + 2;
        double denominator = 5 + 1 / System.Math.Pow(-5, 2);
        double wait = numerator / denominator;
        wait = System.Math.Round(wait, 3);
        Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void ValidCalculate_XLessThanMinus14()
    {
        DataService ds = new DataService();
        double x = -20;
        double result = ds.Calculate(x);
        double wait = -20 + 10 * (-20) - (1 / (-20));
        wait = System.Math.Round(wait, 3);
        Assert.AreEqual(wait, result);
    }

    [TestMethod]
    public void ValidCalculate_VerifyZeroCase()
    {
        DataService ds = new DataService();
        double x = 0;
        double result = ds.Calculate(x);

        // Проверяем, что при x=0 результат действительно -1.0
        Assert.AreEqual(-1.0, result);

        // Проверяем округление
        string resultString = result.ToString("F10");
        Assert.AreEqual("-1.000", resultString.Substring(0, 6));
        {
        }
    }
}
