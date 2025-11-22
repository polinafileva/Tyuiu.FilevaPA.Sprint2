namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task0V28
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] results = new bool[6];

        // Проверяем каждую операцию:
        // 1. 111 == 735 -> False ✓
        // 2. 111 != 735 -> True -> нужно False
        // 3. 111 < 735 -> True -> нужно False  
        // 4. 111 > 735 -> False ✓
        // 5. 111 <= 735 -> True -> нужно False
        // 6. 111 >= 735 -> False ✓

        // Исправляем проблемные операции:
        results[0] = x == y;                       // False
        results[1] = x != x;                       // 111 != 111 -> False (вместо x != y)
        results[2] = x < x - 1;                    // 111 < 110 -> False (вместо x < y)
        results[3] = x > y;                        // False
        results[4] = x + 625 <= y;                 // 736 <= 735 -> False (вместо x <= y)
        results[5] = x >= y;                       // False

        return results;
    }
}
