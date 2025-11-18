namespace Tyuiu.FilevaPA.Sprint2.Task2.V1.Test;
  using Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;


   
    [TestClass]
public sealed class Test1
{
    [TestMethod]
    public void ValidCheckDotInShadedArea_InsideRectangle()
    {
        DataService ds = new DataService();
        int x = 7;
        int y = 7;
        bool result = ds.CheckDotInShadedArea(x, y);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_OutsideRectangle()
    {
        DataService ds = new DataService();
        int x = 2;
        int y = 2;
        bool result = ds.CheckDotInShadedArea(x, y);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_OnBorder()
    {
        DataService ds = new DataService();
        int x = 5;
        int y = 5;
        bool result = ds.CheckDotInShadedArea(x, y);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_CornerCases()
    {
        DataService ds = new DataService();

        // Внутри
        Assert.IsTrue(ds.CheckDotInShadedArea(8, 8));

        // Снаружи
        Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
        Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
        Assert.IsFalse(ds.CheckDotInShadedArea(3, 8));
        Assert.IsFalse(ds.CheckDotInShadedArea(8, 3));
    }

    [TestMethod]
    public void ValidCheckDotInShadedArea_BoundaryValues()
    {
        DataService ds = new DataService();

        // Граничные значения прямоугольника
        Assert.IsTrue(ds.CheckDotInShadedArea(5, 5));
        Assert.IsTrue(ds.CheckDotInShadedArea(10, 10));
        Assert.IsTrue(ds.CheckDotInShadedArea(5, 10));
        Assert.IsTrue(ds.CheckDotInShadedArea(10, 5));

        // За границами прямоугольника
        Assert.IsFalse(ds.CheckDotInShadedArea(4, 5));
        Assert.IsFalse(ds.CheckDotInShadedArea(11, 5));
        Assert.IsFalse(ds.CheckDotInShadedArea(5, 4));
        Assert.IsFalse(ds.CheckDotInShadedArea(5, 11));
    }
}