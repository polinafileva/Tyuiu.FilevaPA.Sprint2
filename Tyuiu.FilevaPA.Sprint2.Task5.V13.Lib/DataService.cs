namespace Tyuiu.FilevaPA.Sprint2.Task5.V13.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task5V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        int nextDay = n + 1;
        int nextMonth = m;
        int nextYear = g;

        // Проверка на високосный год
        bool isLeapYear = (g % 4 == 0 && g % 100 != 0) || (g % 400 == 0);

        // Определяем количество дней в текущем месяце
        int daysInMonth = 0;

        switch (m)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                daysInMonth = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysInMonth = 30;
                break;
            case 2:
                daysInMonth = isLeapYear ? 29 : 28;
                break;
        }

        // Проверяем, нужно ли переходить на следующий месяц
        if (nextDay > daysInMonth)
        {
            nextDay = 1;
            nextMonth++;

            // Проверяем, нужно ли переходить на следующий год
            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear++;
            }
        }

        // Форматируем с ведущими нулями
        string formattedDay = nextDay.ToString("D2");
        string formattedMonth = nextMonth.ToString("D2");

        return $"{formattedDay}.{formattedMonth}.{nextYear}";
    }

    public bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
