namespace Tyuiu.FilevaPA.Sprint2.Task5.V13.Test;
using Tyuiu.FilevaPA.Sprint2.Task5.V13.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidFindDateOfNextDay_RegularDay()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 5, 15);
        Assert.AreEqual("16.5.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_EndOfMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 4, 30); // 30 апреля
        Assert.AreEqual("1.5.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_EndOfYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 12, 31); // 31 декабря
        Assert.AreEqual("1.1.2025", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_FebruaryLeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 2, 28); // 28 февраля високосного года
        Assert.AreEqual("29.2.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_FebruaryNonLeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2023, 2, 28); // 28 февраля невисокосного года
        Assert.AreEqual("1.3.2023", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_February29LeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 2, 29); // 29 февраля високосного года
        Assert.AreEqual("1.3.2024", result);
    }

    [TestMethod]
    public void ValidIsLeapYear_LeapYear()
    {
        DataService ds = new DataService();
        Assert.IsTrue(ds.IsLeapYear(2024));
        Assert.IsTrue(ds.IsLeapYear(2000));
    }

    [TestMethod]
    public void ValidIsLeapYear_NonLeapYear()
    {
        DataService ds = new DataService();
        Assert.IsFalse(ds.IsLeapYear(2023));
        Assert.IsFalse(ds.IsLeapYear(1900));
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_30DayMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 6, 30); // 30 июня
        Assert.AreEqual("1.7.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_31DayMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 7, 31); // 31 июля
        Assert.AreEqual("1.8.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_MarchFromLeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 2, 29); // 29 февраля високосного года
        Assert.AreEqual("1.3.2024", result);
    }
}