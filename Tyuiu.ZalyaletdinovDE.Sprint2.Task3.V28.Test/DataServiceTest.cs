using Tyuiu.ZalyaletdinovDE.Sprint2.Task3.V28.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = Math.Sqrt(Math.PI/2);
            double res = ds.Calculate(x);
            Assert.AreEqual(Math.Round(Math.Sqrt(Math.PI/2), 3, MidpointRounding.AwayFromZero), res);
        }
    }
}
