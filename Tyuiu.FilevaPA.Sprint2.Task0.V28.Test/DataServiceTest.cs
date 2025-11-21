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
        bool[] results = ds.GetCompareOperations(x, y);

        // Проверяем что все элементы массива False
        bool allFalse = true;
        foreach (bool result in results)
        {
            if (result)
            {
                allFalse = false;
                break;
            }
        }

        Assert.AreEqual(6, results.Length);
        Assert.IsTrue(allFalse, "Все элементы массива должны быть False");
    }

    [TestMethod]
    public void ValidGetCompareOperationsSequence()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;
        bool[] results = ds.GetCompareOperations(x, y);

        // Проверяем конкретную последовательность
        bool[] expected = { false, false, false, false, false, false };

        CollectionAssert.AreEqual(expected, results);
    }
}
