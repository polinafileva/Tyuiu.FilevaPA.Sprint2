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
        Assert.AreEqual("16.05.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_EndOfMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 4, 30); // 30 апреля
        Assert.AreEqual("01.05.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_EndOfYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 12, 31); // 31 декабря
        Assert.AreEqual("01.01.2025", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_FebruaryLeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 2, 28); // 28 февраля високосного года
        Assert.AreEqual("29.02.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_FebruaryNonLeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2023, 2, 28); // 28 февраля невисокосного года
        Assert.AreEqual("01.03.2023", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_February29LeapYear()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 2, 29); // 29 февраля високосного года
        Assert.AreEqual("01.03.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_30DayMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 6, 30); // 30 июня
        Assert.AreEqual("01.07.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_31DayMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 7, 31); // 31 июля
        Assert.AreEqual("01.08.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_SingleDigitDayAndMonth()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 8, 8); // 8 августа
        Assert.AreEqual("09.08.2024", result);
    }

    [TestMethod]
    public void ValidFindDateOfNextDay_SeptemberCase()
    {
        DataService ds = new DataService();
        string result = ds.FindDateOfNextDay(2024, 9, 8); // 8 сентября
        Assert.AreEqual("09.09.2024", result);
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
}