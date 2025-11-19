using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

           
            results[0] = x == y;      
            results[1] = x != y;        
            results[2] = x < y;       
            results[3] = y > x;       
            results[4] = y <= x;      
            results[5] = y >= x;      

            return results;
        }
    }
}
