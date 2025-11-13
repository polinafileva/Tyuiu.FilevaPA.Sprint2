namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;

public class DataService : ISprint2Task0V28
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] results = new bool[6];

        // 6 операций сравнения
        results[0] = (x + 15) < y;        // x + 15 < y
        results[1] = (x + 15) > y;        // x + 15 > y
        results[2] = (x + 15) <= y;       // x + 15 <= y
        results[3] = (x + 15) >= y;       // x + 15 >= y
        results[4] = (x + 15) == y;       // x + 15 == y
        results[5] = (x + 15) != y;       // x + 15 != y

        return results;
    }
}
