using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KotlovaEA.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            double y;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 * x - 0.5) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = 5 - 3 * x + (1 + Math.Sin(x)) / (2 * x - 0.5);
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
