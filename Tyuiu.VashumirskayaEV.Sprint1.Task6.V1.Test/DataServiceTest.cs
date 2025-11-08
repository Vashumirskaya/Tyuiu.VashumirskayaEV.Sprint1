using Tyuiu.VashumirskayaEV.Sprint1.Task6.V1.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "1";
            string wait = "Символ: 1 Код: 49";
            var res = ds.SymbolCode(value);
            Assert.AreEqual(wait, res);
        }
    }
}
