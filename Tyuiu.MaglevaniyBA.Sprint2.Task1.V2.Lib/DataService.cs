using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            results[0] = (a < b) && (c < d);

            results[1] = (b > a) || (d < c);

            results[2] = (a != b) & (c != d);

            results[3] = !(a == d) && (b == b);

            results[4] = (c <= d) ^ (a >= b);

            results[5] = (a > d) | (b < c);

            return results;
        }
    }
}
