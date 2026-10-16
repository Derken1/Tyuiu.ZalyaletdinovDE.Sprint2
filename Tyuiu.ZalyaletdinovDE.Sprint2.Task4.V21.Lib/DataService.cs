using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task4.V21.Lib
{
    public class DataService : ISprint2Task4V21
    {
        public double Calculate(double x, double y)
        {
            double res = x < y - 2 ? Math.Pow(2 + (x + 1) / (x * x), y) : (x * x + 10) / (y * y - Math.Pow(Math.Sin(y), 2) + 12);
            return Math.Round(res, 3, MidpointRounding.AwayFromZero);
        }
    }
}
