using Tyuiu.MaglevaniyBA.Sprint2.Task7.V13.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            // ----- Точки внутри круга слева -----

            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 0));      
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 0));        
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.3, -0.9));   

            // ----- Точки внутри правого треугольника -----

            Assert.IsTrue(ds.CheckDotInShadedArea(1, 1));         
            Assert.IsTrue(ds.CheckDotInShadedArea(1.5, 0.5));     
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -0.5));      

            // ----- Точки снаружи -----

            Assert.IsFalse(ds.CheckDotInShadedArea(2, -0.5));     
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 2));      
            Assert.IsFalse(ds.CheckDotInShadedArea(-2, 0));       
            Assert.IsFalse(ds.CheckDotInShadedArea(0.3, -2));     
            Assert.IsFalse(ds.CheckDotInShadedArea(0.2, -1.5));  
        }
    }
}