using Tyuiu.ShaldinDA.Sprint3.Task2.V28.Lib;
namespace Tyuiu.ShaldinDA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(-0.227, res);
        }
    }
}