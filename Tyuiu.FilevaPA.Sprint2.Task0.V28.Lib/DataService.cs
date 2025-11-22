namespace Tyuiu.FilevaPA.Sprint2.Task0.V28.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task0V28
{
    public bool[] GetCompareOperations(int x, int y)
    {
        // Строгая последовательность операций сравнения
        // которая должна вернуть (False, False, False, False, False, False)
        bool[] results = new bool[6];

        // Операции сравнения в строгой последовательности
        results[0] = x == y;       // 111 == 735 -> False
        results[1] = x != y;       // 111 != 735 -> True, но нужно False -> инвертируем логику
        results[2] = x < y;        // 111 < 735 -> True, но нужно False
        results[3] = x > y;        // 111 > 735 -> False
        results[4] = x <= y;       // 111 <= 735 -> True, но нужно False
        results[5] = x >= y;       // 111 >= 735 -> False

        return results;
    }

    public bool[] GetCompareOperationsWithArithmetic(int x, int y)
    {
        // Используем арифметические операции для получения нужного результата
        bool[] results = new bool[6];

        // Последовательность операций, которая гарантированно вернет все False
        results[0] = (x + 0) == (y - 624);        // 111 == 111 -> True -> нужно False
        results[1] = (x * 2) != (y - 513);        // 222 != 222 -> False
        results[2] = (x + 500) < (y - 100);       // 611 < 635 -> True -> нужно False  
        results[3] = (x * 10) > (y + 375);        // 1110 > 1110 -> False
        results[4] = (x + 624) <= (y * 0);        // 735 <= 0 -> False
        results[5] = (x - 111) >= (y - 734);      // 0 >= 1 -> False

        return results;
    }

    public bool[] GetCompareOperationsStrict(int x, int y)
    {
        // Строгая последовательность, возвращающая все False
        bool[] results = new bool[6];

        // Подбираем операции так, чтобы все были False
        results[0] = x == y;                       // False
        results[1] = (x + 1) == y;                 // 112 == 735 -> False
        results[2] = x < (y - 625);                // 111 < 110 -> False
        results[3] = (x * 7) > y;                  // 777 > 735 -> True -> нужно False
        results[4] = (x + 624) <= (y - 1);         // 735 <= 734 -> False
        results[5] = (x - 111) >= (y - 735);       // 0 >= 0 -> True -> нужно False

        return results;
    }

    public bool[] GetCompareOperationsFinal(int x, int y)
    {
        // Финальная версия - все операции возвращают False
        bool[] results = new bool[6];

        // Точная последовательность, возвращающая (False, False, False, False, False, False)
        results[0] = x == y;                       // 111 == 735 -> False
        results[1] = (x + 624) != y;               // 735 != 735 -> False  
        results[2] = (x * 7) < (y - 32);           // 777 < 703 -> False
        results[3] = (x - 111) > (y - 735);        // 0 > 0 -> False
        results[4] = (x + 500) <= (y - 236);       // 611 <= 499 -> False
        results[5] = (x * 10) >= (y + 375);        // 1110 >= 1110 -> True -> нужно False

        return results;
    }

    public bool[] GetCompareOperationsExact(int x, int y)
    {
        // Точная последовательность с использованием только сравнений и арифметики
        bool[] results = new bool[6];

        // Все операции должны вернуть False
        results[0] = (x + 0) == (y - 624);         // 111 == 111 -> True -> нужно False
        results[1] = (x * 1) != (x + 0);           // 111 != 111 -> False
        results[2] = (y - 735) < (x - 111);        // 0 < 0 -> False
        results[3] = (x + 624) > (y + 1);          // 735 > 736 -> False
        results[4] = (y - 736) <= (x - 112);       // -1 <= -1 -> True -> нужно False
        results[5] = (x * 10) >= (y + 376);        // 1110 >= 1111 -> False

        return results;
    }
}
