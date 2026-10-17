using Tyuiu.ZalyaletdinovDE.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("16.3", ds.FindDateOfNextDay(3, 15));
            Assert.AreEqual("1.2", ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual("1.3", ds.FindDateOfNextDay(2, 28));
            Assert.AreEqual("1.5", ds.FindDateOfNextDay(4, 30));
        }
    }
}
