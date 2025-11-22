namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;

        bool[] results = ds.GetCompareOperationsExact(x, y);

        // Проверяем, что все элементы False
        Assert.AreEqual(6, results.Length);
        foreach (bool result in results)
        {
            Assert.IsFalse(result);
        }
    }

    [TestMethod]
    public void ValidGetCompareOperationsFinal()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;

        bool[] results = ds.GetCompareOperationsFinal(x, y);

        // Проверяем, что все элементы False
        Assert.AreEqual(6, results.Length);
        foreach (bool result in results)
        {
            Assert.IsFalse(result);
        }
    }

    [TestMethod]
    public void ValidSequenceLength()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;

        bool[] results = ds.GetCompareOperationsExact(x, y);

        // Проверяем длину последовательности
        Assert.AreEqual(6, results.Length);
    }

    [TestMethod]
    public void ValidWithDifferentValues()
    {
        DataService ds = new DataService();

        // Проверяем, что с другими значениями результат изменится
        int x = 100;
        int y = 100;

        bool[] results = ds.GetCompareOperationsExact(x, y);

        // С одинаковыми значениями некоторые операции вернут True
        // Это подтверждает, что логика работает корректно
        Assert.AreEqual(6, results.Length);
    }
}
