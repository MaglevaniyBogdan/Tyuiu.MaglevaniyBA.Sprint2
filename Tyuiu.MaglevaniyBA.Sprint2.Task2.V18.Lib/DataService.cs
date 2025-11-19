using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
       
            if (x >= 3 && x <= 7 && y >= 3 && y <= 4)
                return true;

            if (x >= 2 && x <= 10 && y >= 6 && y <= 7)
                return true;

            if (x >= 4 && x <= 11 && y >= 8 && y <= 9)
                return true;

            if (x >= 12 && x <= 14 && y >= 5 && y <= 11)
                return true;

            if (x >= 2 && x <= 6 && y == 11)
                return true;

            if (x == 6 && y >= 10 && y <= 12)
                return true;

            return false;
        }
    }
}
