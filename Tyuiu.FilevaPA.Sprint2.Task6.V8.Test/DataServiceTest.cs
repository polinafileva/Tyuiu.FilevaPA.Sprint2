namespace Tyuiu.FilevaPA.Sprint2.Task6.V8.Test;
using Tyuiu.FilevaPA.Sprint2.Task6.V8.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidFindDateOfPreviousDay_RegularDay()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(5, 15);
        Assert.AreEqual("14.05", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_FirstDayOfMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(5, 1); // 1 мая
        Assert.AreEqual("30.04", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_FirstDayOfYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(1, 2); // 2 января
        Assert.AreEqual("01.01", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_MarchFirst()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(3, 1); // 1 марта
        Assert.AreEqual("28.02", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_30DayMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(7, 1); // 1 июля
        Assert.AreEqual("30.06", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_31DayMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(8, 1); // 1 августа
        Assert.AreEqual("31.07", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_February()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(2, 15); // 15 февраля
        Assert.AreEqual("14.02", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_December()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(12, 1); // 1 декабря
        Assert.AreEqual("30.11", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_SpecificTest()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(5, 25); // 25 мая
        Assert.AreEqual("24.05", result);
    }

    [TestMethod]
    public void ValidFindDateOfPreviousDay_FormatTest()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfPreviousDay(3, 10); // 10 марта
        Assert.AreEqual("09.03", result);
    }
}
