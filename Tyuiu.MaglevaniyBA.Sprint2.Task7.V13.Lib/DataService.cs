using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inLeftCircle = (x * x + y * y <= 1) && (x <= 0);

            bool inTriangle = (x >= 0) && (y <= 1) && (y >= x - 1);

            return inLeftCircle || inTriangle;
        }
    }
}
