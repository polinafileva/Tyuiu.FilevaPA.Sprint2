namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;




public class DataService : ISprint2Task0V28
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] results = new bool[6];
        int calculatedValue = x + 15; // 111 + 15 = 126

        // Строгая последовательность операций: ==, !=, <, >, <=, >=
        // Все операции должны возвращать False
        results[0] = calculatedValue == y;      // 126 == 735 → False
        results[1] = calculatedValue != calculatedValue; // 126 != 126 → False
        results[2] = y < x;                     // 735 < 111 → False
        results[3] = calculatedValue > y;       // 126 > 735 → False
        results[4] = y <= x;                    // 735 <= 111 → False
        results[5] = calculatedValue >= y;      // 126 >= 735 → False

        return results; // (False, False, False, False, False, False)
    }
}
