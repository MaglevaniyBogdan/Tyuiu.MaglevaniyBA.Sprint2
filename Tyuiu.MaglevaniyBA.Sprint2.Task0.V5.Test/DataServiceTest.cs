using Tyuiu.MaglevaniyBA.Sprint2.Task0.V5.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;
            bool[] wait = { false, true, true, true, false, true };
            bool[] res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}