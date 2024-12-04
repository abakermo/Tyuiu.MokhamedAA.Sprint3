using Tyuiu.MokhamedAA.Sprint3.Task3.V25.Lib;
namespace Tyuiu.MokhamedAA.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            Assert.AreEqual(6, service.GetMinCharCount("kjhgfuu gujut dtuu", 'u'));
        }
    }
}