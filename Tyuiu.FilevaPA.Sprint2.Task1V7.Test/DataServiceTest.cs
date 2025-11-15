namespace Tyuiu.FilevaPA.Sprint2.Task1.V7.Test;
using Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        DataService ds = new DataService();

        int a = 195;
        int b = 16;
        int c = 14;
        int d = 45;

        bool[] res = ds.GetLogicOperations(a, b, c, d);
        bool[] wait = { true, false, false, true, false, true, false };

        CollectionAssert.AreEqual(wait, res);
    }

    [TestMethod]
    public void ValidGetLogicOperationsIndividual()
    {
        DataService ds = new DataService();

        int a = 195;
        int b = 16;
        int c = 14;
        int d = 45;

        bool[] res = ds.GetLogicOperations(a, b, c, d);

        // Проверка каждого элемента отдельно
        Assert.IsTrue(res[0]);   // True
        Assert.IsFalse(res[1]);  // False
        Assert.IsFalse(res[2]);  // False
        Assert.IsTrue(res[3]);   // False
        Assert.IsFalse(res[4]);  // False
        Assert.IsTrue(res[5]);   // True
        Assert.IsFalse(res[6]);  // False
    }

    [TestMethod]
    public void ValidGetLogicOperationsWithDifferentValues()
    {
        DataService ds = new DataService();

        // Тест с другими значениями для проверки устойчивости
        int a = 100;
        int b = 20;
        int c = 10;
        int d = 30;

        bool[] res = ds.GetLogicOperations(a, b, c, d);

        // Проверяем, что метод работает без ошибок
        Assert.AreEqual(7, res.Length);
    }
    }
}
