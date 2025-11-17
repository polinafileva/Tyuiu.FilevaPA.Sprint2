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
    public void ValidGetCompareOperations_CheckOperationsSequence()
    {
        DataService ds = new DataService();
        int x = 111;
        int y = 735;
        bool[] res = ds.GetCompareOperations(x, y);

        // Проверяем что все операции возвращают False
        for (int i = 0; i < res.Length; i++)
        {
            Assert.IsFalse(res[i], $"Операция с индексом {i} должна возвращать False");
        }
    }
}
