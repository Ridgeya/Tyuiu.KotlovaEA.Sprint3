using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KotlovaEA.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double multSeries = 0;

            while (startValue <= stopValue)
            {
                multSeries = multSeries + Math.Pow(6.0 / Math.Pow(value, startValue), 2);

                startValue++;
            }

            return Math.Round(multSeries, 3);
        }
    }
}
