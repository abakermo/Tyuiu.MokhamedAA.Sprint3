using Tyuiu.MokhamedAA.Sprint3.Task1.V7.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.25;
            int start = 1;
            int end = 9;

            Console.WriteLine("a = " + a);
            Console.WriteLine("начальный шаг = " + start);
            Console.WriteLine("конечный шаг = " + end);

            DataService ds = new DataService();
            double MultiplySeries = ds.GetMultiplySeries(a, start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(MultiplySeries);
            Console.ReadKey();
        }
    }
}
