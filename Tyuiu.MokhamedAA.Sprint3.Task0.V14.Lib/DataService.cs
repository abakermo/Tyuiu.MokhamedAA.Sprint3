using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MokhamedAA.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries * Math.Pow((1) / (Math.Pow(i, value)), -1);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
