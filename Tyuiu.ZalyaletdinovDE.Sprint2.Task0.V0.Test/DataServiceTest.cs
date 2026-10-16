using Tyuiu.ZalyaletdinovDE.Sprint2.Task0.V0.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 16;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, true, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
