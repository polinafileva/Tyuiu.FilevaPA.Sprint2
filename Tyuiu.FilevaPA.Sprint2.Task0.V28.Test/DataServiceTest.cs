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

        // Проверяем что все элементы False
        for (int i = 0; i < results.Length; i++)
        {
            Assert.IsFalse(results[i], $"Элемент {i} должен быть False");
        }
    }
}
