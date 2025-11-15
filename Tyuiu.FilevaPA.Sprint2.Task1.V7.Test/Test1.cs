namespace Tyuiu.FilevaPA.Sprint2.Task1.V7.Test;
using Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;

[TestClass]
public sealed class DataServiceTest
{


    [TestMethod]
    public void ValidGetLogicOperationsIndividual()
    {
        DataService ds = new DataService();

        int a = 195;
        int b = 16;
        int c = 14;
        int d = 45;

        bool[] res = ds.GetLogicOperations(a, b, c, d);
        bool[] wait = { true, false, false, false, true, false };

        CollectionAssert.AreEqual(wait, res);
    }

}