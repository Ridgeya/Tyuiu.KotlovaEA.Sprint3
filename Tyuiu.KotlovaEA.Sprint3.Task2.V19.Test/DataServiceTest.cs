using Tyuiu.KotlovaEA.Sprint3.Task2.V19.Lib;
namespace Tyuiu.KotlovaEA.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = -0.709;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
