using Tyuiu.ShaldinDA.Sprint3.Task6.V5.Lib;

namespace Tyuiu.ShaldinDA.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startv = 15;
            int stopv = 22;

            int res = ds.GetSumTheDivisors(startv, stopv);

            int wait = 242;
            Assert.AreEqual(wait, res);
        }
    }
}