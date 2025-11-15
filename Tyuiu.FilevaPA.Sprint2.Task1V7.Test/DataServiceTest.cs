namespace Tyuiu.FilevaPA.Sprint2.Task1.V7.Test;
using Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;

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
        bool[] wait = { true, false, false, false, true, false, false };

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
        Assert.IsFalse(res[3]);  // False
        Assert.IsTrue(res[4]);   // True
        Assert.IsFalse(res[5]);  // False
        Assert.IsFalse(res[6]);  // False
    }

    [TestMethod]
    public void ValidGetLogicOperationsCalculations()
    {
        DataService ds = new DataService();

        int a = 195;
        int b = 16;
        int c = 14;
        int d = 45;

        bool[] res = ds.GetLogicOperations(a, b, c, d);

        // Проверка вычислений
        Assert.AreEqual(195 > (16 + 14), res[0]);      // 195 > 30 = True
        Assert.AreEqual(16 <= 14, res[1]);             // False
        Assert.AreEqual(195 == (16 * 12), res[2]);     // 195 == 192 = False
        Assert.AreEqual((45 / 9) >= 14, res[3]);       // 5 >= 14 = False
        Assert.AreEqual(14 < 45, res[4]);              // True
        Assert.AreEqual((195 % 19) == 0, res[5]);      // 5 == 0 = False
        Assert.AreEqual((16 + 14) == 195, res[6]);     // 30 == 195 = False
    }
}

