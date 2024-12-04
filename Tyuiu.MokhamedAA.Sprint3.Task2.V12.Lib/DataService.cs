using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MokhamedAA.Sprint3.Task2.V12.Lib

    public class DataService : ISprint3Task2V12
        {
            public double GetMultiplySeries(int value, int startValue, int stopValue)
            {
                double multSeries = 1;
                for (int i = startValue; i <= stopValue; i++)
                {
                    multSeries = multSeries * Math.Pow((300 / (startValue + Math.Pow(value, startValue))), startValue);
                    startValue++;
                }
                return Math.Round(multSeries, 3);
            }
        }
    }


