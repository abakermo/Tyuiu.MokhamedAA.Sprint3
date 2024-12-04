using Tyuiu.MokhamedAA.Sprint3.Task0.V14.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
     

            int value = 2;
            int startvalue = 1;
            int stopvalue = 5;

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произведение ряда = " + ds.GetMultiplySeries(value, startvalue, stopvalue));
            Console.ReadKey();
        }
    }
}
