namespace Tyuiu.FilevaPA.Sprint2.Task2.V1.Test;
    using Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
{
   
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        DataService ds = new DataService();

        // Точка в верхнем левом заштрихованном квадрате
        int x = 2;
        int y = 2;

        bool result = ds.CheckDotInShadedArea(x, y);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_TopRight()
    {
        DataService ds = new DataService();

        // Точка в верхнем правом заштрихованном квадрате
        int x = 14;
        int y = 2;

        bool result = ds.CheckDotInShadedArea(x, y);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_Center()
    {
        DataService ds = new DataService();

        // Точка в центральном заштрихованном квадрате
        int x = 8;
        int y = 8;

        bool result = ds.CheckDotInShadedArea(x, y);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_Outside()
    {
        DataService ds = new DataService();

        // Точка вне заштрихованных областей
        int x = 5;
        int y = 5;

        bool result = ds.CheckDotInShadedArea(x, y);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_Boundary()
    {
        DataService ds = new DataService();

        // Точка на границе заштрихованной области
        int x = 3;
        int y = 3;

        bool result = ds.CheckDotInShadedArea(x, y);

        Assert.IsTrue(result);

    }
    }

