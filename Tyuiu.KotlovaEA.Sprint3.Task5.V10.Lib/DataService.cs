using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KotlovaEA.Sprint3.Task5.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int x = 5; 

            for (int i = 1; i <= 3; i++)
            {
                for (int k = startValue; k <= stopValue; k++)
                {
                    sumSeries = sumSeries + ((Math.Pow(x, 3) * k) + 2);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
