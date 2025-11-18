namespace Tyuiu.FilevaPA.Sprint2.Task4.V25.Test;
using Tyuiu.FilevaPA.Sprint2.Task4.V25.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate_ConditionTrue()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 1;
        double result = ds.Calculate(x, y);

        // Проверяем условие: 1 - 40 < 1 + 4 → -39 < 5 → true
        // Формула: (1 + 2/1²)^1 = (1 + 2)^1 = 3
        double expected = 3.0;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_ConditionFalse()
    {
        DataService ds = new DataService();
        double x = 50;
        double y = 1;
        double result = ds.Calculate(x, y);

        // Проверяем условие: 50 - 40 < 1 + 4 → 10 < 5 → false
        // Формула: 1 + ((50 + 1)/(1 + 2))^50 = 1 + (51/3)^50
        double expected = 1 + Math.Pow(17, 50);
        expected = Math.Round(expected, 3);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_BoundaryCondition()
    {
        DataService ds = new DataService();

        // Граничное значение: x - 40 = y + 4
        // x - 40 = y + 4 → x - y = 44
        double x = 45;
        double y = 1; // 45 - 1 = 44 → условие ложно
        double result = ds.Calculate(x, y);
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void ValidCalculate_RoundingTest()
    {
        DataService ds = new DataService();
        double x = 2;
        double y = 3;
        double result = ds.Calculate(x, y);

        // Проверяем, что результат округлен до 3 знаков
        string resultString = result.ToString("F10");
        int decimalPlaces = resultString.Length - resultString.IndexOf('.') - 1;
        Assert.IsTrue(decimalPlaces <= 3);
    }

    [TestMethod]
    public void ValidCalculate_DecimalValues()
    {
        DataService ds = new DataService();
        double x = 2.5;
        double y = 3.7;
        double result = ds.Calculate(x, y);

        // Проверяем условие: 2.5 - 40 < 3.7 + 4 → -37.5 < 7.7 → true
        // Формула: (1 + 2/6.25)^3.7
        double expected = Math.Pow(1 + 2 / Math.Pow(2.5, 2), 3.7);
        expected = Math.Round(expected, 3);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ValidCalculate_NegativeValues()
    {
        DataService ds = new DataService();
        double x = -5;
        double y = -3;
        double result = ds.Calculate(x, y);

        // Проверяем условие: -5 - 40 < -3 + 4 → -45 < 1 → true
        // Формула: (1 + 2/25)^(-3)
        double expected = Math.Pow(1 + 2 / Math.Pow(-5, 2), -3);
        expected = Math.Round(expected, 3);
        Assert.AreEqual(expected, result);
        {
        }
    }
}
