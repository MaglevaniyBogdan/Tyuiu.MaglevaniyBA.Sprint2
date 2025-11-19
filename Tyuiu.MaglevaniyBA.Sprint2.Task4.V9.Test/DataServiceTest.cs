using Tyuiu.MaglevaniyBA.Sprint2.Task4.V9.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WhenConditionTrue_ReturnsFirstExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 20; // 1 + 5 = 6 < 20/2 = 10 → true
            double expected = Math.Pow(7 + 1 / (x * x), y);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void Calculate_WhenConditionFalse_ReturnsSecondExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10; // 10 + 5 = 15 > 10/2 = 5 → false
            double expected = Math.Pow(x, 4) - (3 / y);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void Calculate_WhenBoundaryCondition_ReturnsSecondExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = -10; // 0 + 5 = 5 > -10/2 = -5 → false
            double expected = Math.Pow(x, 4) - (3 / y);
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}