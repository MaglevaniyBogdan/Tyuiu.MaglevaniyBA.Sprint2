using Tyuiu.MaglevaniyBA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(2023, 9, 8);
            Assert.AreEqual("09.09.2023", result);

            string result1 = ds.FindDateOfNextDay(2023, 6, 15);
            Assert.AreEqual("16.06.2023", result1);

            string result2 = ds.FindDateOfNextDay(2023, 12, 31);
            Assert.AreEqual("01.01.2024", result2);

            string result3 = ds.FindDateOfNextDay(2023, 2, 28);
            Assert.AreEqual("01.03.2023", result3);
        }
    }
}