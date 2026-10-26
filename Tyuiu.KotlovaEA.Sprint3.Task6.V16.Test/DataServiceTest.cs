using Tyuiu.KotlovaEA.Sprint3.Task6.V16.Lib;
namespace Tyuiu.KotlovaEA.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}
