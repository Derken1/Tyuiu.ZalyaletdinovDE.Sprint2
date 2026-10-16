using Tyuiu.ZalyaletdinovDE.Sprint2.Task2.V13.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 6;
            bool res;
            res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }
    }
}
