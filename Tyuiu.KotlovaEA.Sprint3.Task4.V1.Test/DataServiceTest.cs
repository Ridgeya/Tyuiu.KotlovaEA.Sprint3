using Tyuiu.KotlovaEA.Sprint3.Task4.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint3.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.962;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
