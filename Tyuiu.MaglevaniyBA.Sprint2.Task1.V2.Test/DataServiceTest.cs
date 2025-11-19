using Tyuiu.MaglevaniyBA.Sprint2.Task1.V2.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;
            bool[] wait = { true, true, true, true, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}