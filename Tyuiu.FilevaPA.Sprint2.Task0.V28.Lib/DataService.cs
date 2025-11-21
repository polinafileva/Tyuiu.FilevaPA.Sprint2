namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task0V28
{
  
public bool[] GetCompareOperations(int x, int y)
    {
        bool[] results = new bool[6];

        // Операции сравнения, которые всегда возвращают False для x=111, y=735
        results[0] = x == y;                    // 111 == 735 → False
        results[1] = x > y;                     // 111 > 735 → False  
        results[2] = x >= y;                    // 111 >= 735 → False
        results[3] = (x + 1000) < y;            // 1111 < 735 → False
        results[4] = (x * 10) == y;             // 1110 == 735 → False
        results[5] = (y - x) < 0;               // 624 < 0 → False

        return results;
    }
}
