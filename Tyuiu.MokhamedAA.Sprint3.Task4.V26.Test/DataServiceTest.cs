using Tyuiu.MokhamedAA.Sprint3.Task4.V26.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startVale = -5;
            int stopValue = 5;

            double res = ds.Calculate(startVale, stopValue);

            double wait = -1.924;
            Assert.AreEqual(wait, res);
        }
    }
}