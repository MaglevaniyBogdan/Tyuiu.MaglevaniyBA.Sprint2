using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = g;

            
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28, 
                _ => throw new ArgumentException("Неверный номер месяца")
            };

            if (nextDay > daysInMonth)
            {
                nextDay = 1;
                nextMonth = m + 1;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear = g + 1;
                }
            }

            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}
