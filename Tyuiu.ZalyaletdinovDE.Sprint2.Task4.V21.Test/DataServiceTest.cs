using Tyuiu.ZalyaletdinovDE.Sprint2.Task4.V21.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = -1;
            int y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(4, res);
        }
    }
}
