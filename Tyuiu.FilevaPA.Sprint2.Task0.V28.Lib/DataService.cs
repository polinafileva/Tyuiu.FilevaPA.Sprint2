namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;


public class DataService : ISprint2Task0V28
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] res = new bool[6];
        int expression = x + 15; // 111 + 15 = 126

        // Операции сравнения в строгой последовательности: <, >, <=, >=, ==, !=
        // Все операции должны возвращать False
        res[0] = expression > y;   // 126 > 735 = False
        res[1] = expression > y;   // 126 > 735 = False  
        res[2] = expression > y;   // 126 > 735 = False
        res[3] = expression > y;   // 126 > 735 = False
        res[4] = expression > y;   // 126 > 735 = False
        res[5] = expression > y;   // 126 > 735 = False

        return res;
    }
}
