namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task0V28
{
  
public bool[] GetCompareOperations(int x, int y)
    {
        bool[] results = new bool[6];

        // Все операции возвращают False для x = 111, y = 735
        results[0] = x == y;                    // 111 == 735 → False
        results[1] = (x + 100) == (y - 500);    // 211 == 235 → False
        results[2] = (x * 10) < y;              // 1110 < 735 → False
        results[3] = (y / 10) > x;              // 73 > 111 → False
        results[4] = x <= (x - 50);             // 111 <= 61 → False
        results[5] = y >= (y + 10);             // 735 >= 745 → False

        return results;
    }
}
