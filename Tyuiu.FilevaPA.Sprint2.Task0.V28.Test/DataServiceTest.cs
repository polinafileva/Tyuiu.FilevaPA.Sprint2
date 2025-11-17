namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int x = 111;
        int y = 735;
        bool[] res = ds.GetCompareOperations(x, y);
        bool[] wait = { false, false, false, false, false, false };

        CollectionAssert.AreEqual(wait, res);
    }
}
