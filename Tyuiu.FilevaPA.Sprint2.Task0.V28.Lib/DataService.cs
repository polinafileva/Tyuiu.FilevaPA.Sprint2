namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;




public class DataService : ISprint2Task0V28
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] results = new bool[6];

        // Последовательность операций, возвращающая все False
        results[0] = x == y;      // 111 == 735 = False
        results[1] = x != x;      // 111 != 111 = False
        results[2] = y < x;       // 735 < 111 = False
        results[3] = x > y;       // 111 > 735 = False
        results[4] = y <= x;      // 735 <= 111 = False
        results[5] = x >= y;      // 111 >= 735 = False

        return results; // (False, False, False, False, False, False)
    }
}
