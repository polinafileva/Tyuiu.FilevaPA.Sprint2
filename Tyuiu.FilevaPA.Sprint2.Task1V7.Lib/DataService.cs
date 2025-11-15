namespace Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;
using Tyuiu.FilevaPA.Sprint2.Task1.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task1V7
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] res = new bool[7];

        // True: 195 > (16 + 14) = 195 > 30 = True
        res[0] = a > (b + c);

        // False: (16 <= 14) = False И (195-45=150 < 0) = False
        res[1] = (b <= c) && ((a - d) < 0);

        // False: (195 != 16*12=192) = True И (45/9=5 >= 14) = False
        res[2] = (a != b * 12) && ((d / 9) >= c);

        // True: (14 < 45) = True И (195%19=5 != 0) = True
        res[3] = (c < d) && ((a % 19) != 0);

        // False: (45 >= 45) = True И (16+14=30 == 195) = False
        res[4] = (d >= 45) && ((b + c) == a);

        // True: (195 == 195) = True ИЛИ (14*3=42 < 45) = True
        res[5] = (a == 195) || ((c * 3) < d);

        // False: (45 > 50) = False И (195/16=12 <= 14) = True
        res[6] = (d > 50) && ((a / b) <= c);

        return res;
    }
}
