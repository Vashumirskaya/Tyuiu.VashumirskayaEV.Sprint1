using Tyuiu.VashumirskayaEV.Sprint1.Task2.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateSquarePerimetr(x);
            Assert.AreEqual(8, res);
        }
    }
}
