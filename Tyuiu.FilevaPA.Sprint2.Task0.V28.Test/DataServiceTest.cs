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
    public void ValidGetCompareOperations_CheckSequence()
    {
        DataService ds = new DataService();
        int x = 111;
        int y = 735;
        bool[] res = ds.GetCompareOperations(x, y);

        // Проверяем строгую последовательность операций
        Assert.IsFalse(res[0], "Операция == должна возвращать False");
        Assert.IsFalse(res[1], "Операция != должна возвращать False");
        Assert.IsFalse(res[2], "Операция < должна возвращать False");
        Assert.IsFalse(res[3], "Операция > должна возвращать False");
        Assert.IsFalse(res[4], "Операция <= должна возвращать False");
        Assert.IsFalse(res[5], "Операция >= должна возвращать False");
    }
    }

