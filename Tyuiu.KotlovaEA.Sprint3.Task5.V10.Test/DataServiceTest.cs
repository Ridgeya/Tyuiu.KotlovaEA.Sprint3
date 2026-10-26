using Tyuiu.KotlovaEA.Sprint3.Task5.V10.Lib;
namespace Tyuiu.KotlovaEA.Sprint3.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 20685;

            Assert.AreEqual(wait, res);
        }
    }
}
