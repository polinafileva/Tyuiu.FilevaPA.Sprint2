namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;


[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetCompareOperations()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;

        bool[] res = ds.GetCompareOperations(x, y);
        bool[] wait = { false, false, false, false, false, false };

        CollectionAssert.AreEqual(wait, res);
    }

    [TestMethod]
    public void ValidGetCompareOperationsIndividual()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;

        bool[] res = ds.GetCompareOperations(x, y);

        // Проверка каждого элемента отдельно
        Assert.IsFalse(res[0]);  // False
        Assert.IsFalse(res[1]);  // False
        Assert.IsFalse(res[2]);  // False
        Assert.IsFalse(res[3]);  // False
        Assert.IsFalse(res[4]);  // False
        Assert.IsFalse(res[5]);  // False
    }

    [TestMethod]
    public void ValidGetCompareOperationsWithDifferentValues()
    {
        DataService ds = new DataService();

        // Тест с другими значениями
        int x = 100;
        int y = 200;

        bool[] res = ds.GetCompareOperations(x, y);

        // Проверяем, что метод работает без ошибок
        Assert.AreEqual(6, res.Length);
    }
}
