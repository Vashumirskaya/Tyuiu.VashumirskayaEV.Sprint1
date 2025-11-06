using Tyuiu.VashumirskayaEV.Sprint1.Task1.V24.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, res);
        }
    }
}
