using Tyuiu.MokhamedAA.Sprint3.Task6.V5.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 302;

            Assert.AreEqual(wait, res);
        }
    }
}