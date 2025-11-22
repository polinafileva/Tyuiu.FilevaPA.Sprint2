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

        // Проверяем длину массива
        Assert.AreEqual(6, results.Length);

        // Проверяем, что ВСЕ элементы False
        for (int i = 0; i < results.Length; i++)
        {
            Assert.IsFalse(results[i], $"Ошибка в позиции {i}: ожидалось False, получено {results[i]}");
        }
    }

    [TestMethod]
    public void ValidGetCompareOperationsWithValues()
    {
        DataService ds = new DataService();

        int x = 111;
        int y = 735;

        bool[] results = ds.GetCompareOperations(x, y);

        // Конкретная проверка каждой операции
        Assert.IsFalse(results[0]); // 111 == 735 -> False
        Assert.IsFalse(results[1]); // 111 != 111 -> False
        Assert.IsFalse(results[2]); // 111 < 110 -> False
        Assert.IsFalse(results[3]); // 111 > 735 -> False
        Assert.IsFalse(results[4]); // 736 <= 735 -> False
        Assert.IsFalse(results[5]); // 111 >= 735 -> False
    }
}
