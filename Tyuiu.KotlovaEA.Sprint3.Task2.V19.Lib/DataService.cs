using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KotlovaEA.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                smSeries = sumSeries + (Math.Cos(startValue) * 0.5);

                startValue++;
            }
            while (startValue <= stopValue);

            return Math.Round(sumSeries, 3);
        }
    }
}
