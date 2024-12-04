using Tyuiu.MokhamedAA.Sprint3.Task4.V26.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task4.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
