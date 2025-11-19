namespace Tyuiu.FilevaPA.Sprint2.Task7.V9.Test;
using Tyuiu.FilevaPA.Sprint2.Task7.V9.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService ds = new DataService();

        // Точка внутри заштрихованной области
        Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.3));

        // Точка на границах
        Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));

        // Точка вне заштрихованной области
        Assert.IsFalse(ds.CheckDotInShadedArea(0, 0.6));

    }
   }
