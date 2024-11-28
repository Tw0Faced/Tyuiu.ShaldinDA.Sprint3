using Tyuiu.ShaldinDA.Sprint3.Task1.V13.Lib;
namespace Tyuiu.ShaldinDA.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            var cal = new DataService();
            double value = 1.2;
            int startValue = 1;
            int stopValue = 7;
            double res = cal.GetMultiplySeries(value, startValue, stopValue);
            double wait = 18059.231;
            Assert.AreEqual(res, wait);
        }
    }
}