namespace Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
public class DataService : ISprint2Task1V7
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] res = new bool[6];

        // True: 195 > (16 + 14) = 195 > 30 = True
        res[0] = a > (b + c);

        // False: (16 <= 14) = False
        res[1] = b <= c;

        // False: (195 == 16*12=192) = False
        res[2] = a == (b * 12);

        // False: (45/9=5 >= 14) = False
        res[3] = (d / 9) >= c;

        // True: (14 < 45) = True
        res[4] = c < d;

        // False: (195%19=5 == 0) = False
        res[5] = (a % 19) == 0;

        return res;
    }
    }
