using Tyuiu.KotlovaEA.Sprint3.Task3.V18.Lib;
namespace Tyuiu.KotlovaEA.Sprint3.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "4n5nvf 56 bgy";
            char item = 'n';

            string res = ds.ReplaceNumOnChar(value, item);

            string wait = "nnnnvf nn bgy";

            Assert.AreEqual(wait, res);
        }
    }
}
