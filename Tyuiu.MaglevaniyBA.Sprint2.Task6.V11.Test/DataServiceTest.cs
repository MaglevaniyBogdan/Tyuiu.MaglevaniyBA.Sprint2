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

            string result1 = ds.FindDateOfNextDay(2023, 6, 15);
            Assert.AreEqual("2023-06-16", result1);

            string result2 = ds.FindDateOfNextDay(2023, 4, 30);
            Assert.AreEqual("2023-05-01", result2);

           
            string result3 = ds.FindDateOfNextDay(2023, 1, 31);
            Assert.AreEqual("2023-02-01", result3);

            string result4 = ds.FindDateOfNextDay(2023, 2, 28);
            Assert.AreEqual("2023-03-01", result4);

            string result5 = ds.FindDateOfNextDay(2023, 12, 31);
            Assert.AreEqual("2024-01-01", result5);

            string result6 = ds.FindDateOfNextDay(2023, 2, 15);
            Assert.AreEqual("2023-02-16", result6);

            string result7 = ds.FindDateOfNextDay(2023, 3, 31);
            Assert.AreEqual("2023-04-01", result7);
        }
    }
}