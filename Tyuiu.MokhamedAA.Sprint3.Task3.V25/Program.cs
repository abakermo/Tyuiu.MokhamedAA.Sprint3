using Tyuiu.MokhamedAA.Sprint3.Task3.V25.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            string str;
            char c;
            Console.WriteLine("* Введите значние х:                                                       ");
            str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetMinCharCount(str, c));
            Console.ReadKey();
        }
    }
}
