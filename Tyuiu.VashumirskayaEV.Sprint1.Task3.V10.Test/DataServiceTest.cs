using Tyuiu.VashumirskayaEV.Sprint1.Task3.V10.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double number = 23.6;
            string wait = "23 руб. 60 коп.";
            var res = ds.NumberToMoney(number);
            Assert.AreEqual(wait, res);
        }
    }
}
