namespace Tyuiu.FilevaPA.Sprint2.Task7.V9.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;
public class DataService : ISprint2Task7V9
{
    public bool CheckDotInShadedArea(double x, double y)
    {
        bool aboveSin = y > Math.Sin(x);
        bool belowLine = y < 0.5;
        bool inXRange = x >= -Math.PI && x <= Math.PI;

        return aboveSin && belowLine && inXRange;
    }
}
    
    