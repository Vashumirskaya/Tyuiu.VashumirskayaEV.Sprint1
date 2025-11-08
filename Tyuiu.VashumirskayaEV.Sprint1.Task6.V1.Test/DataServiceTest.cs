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
            double x1 = 1;
            double y1 = 1;
            double x2 = 4;
            double y2 = 5;
            int wait = 5;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
