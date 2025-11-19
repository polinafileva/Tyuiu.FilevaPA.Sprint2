namespace Tyuiu.FilevaPA.Sprint2.Task6.V8.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task6V8
{
    public string FindDateOfPreviousDay(int m, int n)
    {
        int prevDay = m - 1;
        int prevMonth = n;

        // Определяем количество дней в предыдущем месяце
        int daysInPrevMonth = 0;

        // Сокращенная форма switch
        daysInPrevMonth = (prevMonth - 1) switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => 28, // Февраль (не високосный)
            0 => 31, // Декабрь предыдущего года
            _ => 0
        };

        // Если день стал 0, переходим к предыдущему месяцу
        if (prevDay == 0)
        {
            prevMonth--;

            // Если месяц стал 0, переходим к предыдущему году
            if (prevMonth == 0)
            {
                prevMonth = 12;
            }

            prevDay = daysInPrevMonth;
        }

        // Форматируем с ведущими нулями (только день и месяц)
        string formattedDay = prevDay.ToString("D2");
        string formattedMonth = prevMonth.ToString("D2");

        return $"{formattedDay}.{formattedMonth}";
    }
}
