using Tyuiu.MaglevaniyBA.Sprint2.Task2.V18.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));   
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 4));   
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 6));   
            Assert.IsTrue(ds.CheckDotInShadedArea(10, 7));  
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 9));   
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 8));  
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 11));  
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 12));  

          

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(8, 3));
            Assert.IsFalse(ds.CheckDotInShadedArea(11, 4));
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 5));
            Assert.IsFalse(ds.CheckDotInShadedArea(7, 10)); 
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 2));
        }
    }
}