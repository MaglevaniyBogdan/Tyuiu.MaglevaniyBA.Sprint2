using Tyuiu.MaglevaniyBA.Sprint2.Task3.V9.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_PositiveNumber_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            double x = 8;
            double expected = 8 * Math.Pow((8 + 15) / (8 - 7), 8);
            expected = Math.Round(expected, 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Zero_ReturnsOne()
        {
            DataService ds = new DataService();
            double x = 0;
            double expected = 1; // sin(0) + cos(0) = 0 + 1 = 1
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_NegativeInMiddleRange_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            double x = -5;
            double expected = Math.Pow(1 + 4 / (x * x), x);
            expected = Math.Round(expected, 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_NegativeBelowRange_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            double x = -15;
            double expected = 11 * x + (1 / x);
            expected = Math.Round(expected, 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_BoundaryValue_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            double x = -13;
            double expected = 11 * x + (1 / x);
            expected = Math.Round(expected, 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_NegativeCloseToZero_ReturnsCorrectValue()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double expected = Math.Pow(1 + 4 / (x * x), x);
            expected = Math.Round(expected, 3);
            double result = ds.Calculate(x);
            Assert.AreEqual(expected, result);
        }

    }
}