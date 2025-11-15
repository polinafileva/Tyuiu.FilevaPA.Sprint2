namespace Tyuiu.FilevaPA.Sprint2.Task2.V1.Test;
    using Tyuiu.FilevaPA.Sprint2.Task2.V1.Lib;
{
   
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
          
            int x = 2;
            int y = 2;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(result);
        }

    }

