using Tyuiu.ShaldinDA.Sprint3.Task0.V6.Lib;
namespace Tyuiu.ShaldinDA.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new DataService();
            double res = calc.GetMultiplySeries(1, 15);
            Assert.IsTrue(res > 0);
        }
    }
}