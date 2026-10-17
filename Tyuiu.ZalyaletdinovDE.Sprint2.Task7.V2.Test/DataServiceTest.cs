using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZalyaletdinovDE.Sprint2.Task7.V2.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x1 = 0.0;
            double y1 = -0.5;
            Assert.IsTrue(ds.CheckDotInShadedArea(x1, y1));

            double x2 = 0.5;
            double y2 = 0.1;
            Assert.IsTrue(ds.CheckDotInShadedArea(x2, y2));

            double x3 = 0.2;
            double y3 = 0.7;
            Assert.IsFalse(ds.CheckDotInShadedArea(x3, y3));

            double x4 = -0.5;
            double y4 = 0.2;
            Assert.IsFalse(ds.CheckDotInShadedArea(x4, y4));
        }
    }
}