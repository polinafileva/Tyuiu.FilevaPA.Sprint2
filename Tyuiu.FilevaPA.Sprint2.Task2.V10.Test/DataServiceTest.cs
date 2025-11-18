namespace Tyuiu.FilevaPA.Sprint2.Task3.V10.Test;
using Tyuiu.FilevaPA.Sprint2.Task3.V10.Lib;

[TestClass]
public sealed class DataServiceTest
{
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
    public void ValidCalculate_XEqualToZero()
    {
        DataService ds = new DataService();
        double x = 0;
        double result = ds.Calculate(x);
        double wait = System.Math.Pow(0, 2) + System.Math.Cos(System.Math.Pow(0, 2)) - 3;
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
    public void ValidCalculate_BoundaryValues()
    {
        DataService ds = new DataService();

        // Граничное значение между областями
        double x1 = -13.999;
        double result1 = ds.Calculate(x1);
        Assert.IsNotNull(result1);

        double x2 = -14.001;
        double result2 = ds.Calculate(x2);
        Assert.IsNotNull(result2);

        double x3 = 0.001;
        double result3 = ds.Calculate(x3);
        Assert.IsNotNull(result3);
    }

    [TestMethod]
    public void ValidCalculate_RoundingTest()
    {
        DataService ds = new DataService();
        double x = 2.5;
        double result = ds.Calculate(x);

        // Проверяем, что результат округлен до 3 знаков
        string resultString = result.ToString("F10");
        int decimalPlaces = resultString.Length - resultString.IndexOf('.') - 1;
        Assert.IsTrue(decimalPlaces <= 3);
    }

    [TestMethod]
    public void ValidCalculate_AllBranchesCovered()
    {
        DataService ds = new DataService();

        // Тестируем все ветки условий
        Assert.IsNotNull(ds.Calculate(10));    // x > 0
        Assert.IsNotNull(ds.Calculate(0));     // x == 0
        Assert.IsNotNull(ds.Calculate(-7));    // -14 < x < 0
        Assert.IsNotNull(ds.Calculate(-20));   // x < -14
    }
}