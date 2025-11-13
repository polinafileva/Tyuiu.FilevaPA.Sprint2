namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Test;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;


[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();

        // Тест с x = 111, y = 735
        int x = 111;
        int y = 735;
        bool[] wait = { false, false, false, false, false, false }; // Ожидаемый результат
        bool[] result = ds.GetCompareOperations(x, y);

        // Проверяем все 6 операций
        for (int i = 0; i < 6; i++)
        {
            Assert.AreEqual(wait[i], result[i], $"Ошибка в операции {i + 1}");
        }
    }

    [TestMethod]
    public void ValidGetCompareOperationsDifferentValues()
    {
        DataService ds = new DataService();

        // Дополнительный тест с другими значениями
        int x = 10;
        int y = 25;
        bool[] result = ds.GetCompareOperations(x, y);

        // 10 + 15 = 25, поэтому:
        // 25 < 25 = False
        // 25 > 25 = False  
        // 25 <= 25 = True
        // 25 >= 25 = True
        // 25 == 25 = True
        // 25 != 25 = False
        bool[] wait = { false, false, true, true, true, false };

        for (int i = 0; i < 6; i++)
        {
            Assert.AreEqual(wait[i], result[i], $"Ошибка в операции {i + 1}");
        }
    }

    [TestMethod]
    public void ValidGetCompareOperationsWhenXPlus15LessThanY()
    {
        DataService ds = new DataService();

        // Тест когда x + 15 < y
        int x = 5;
        int y = 30;
        bool[] result = ds.GetCompareOperations(x, y);

        // 5 + 15 = 20, поэтому:
        // 20 < 30 = True
        // 20 > 30 = False  
        // 20 <= 30 = True
        // 20 >= 30 = False
        // 20 == 30 = False
        // 20 != 30 = True
        bool[] wait = { true, false, true, false, false, true };

        for (int i = 0; i < 6; i++)
        {
            Assert.AreEqual(wait[i], result[i], $"Ошибка в операции {i + 1}");
        }
    }
}
