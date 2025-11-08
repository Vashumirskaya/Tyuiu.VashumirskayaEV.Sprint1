using Tyuiu.VashumirskayaEV.Sprint1.Task7.V21.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 12.182;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
