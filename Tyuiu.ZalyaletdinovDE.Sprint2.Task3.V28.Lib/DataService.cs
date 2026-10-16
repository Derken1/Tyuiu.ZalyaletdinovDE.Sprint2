using System.Transactions;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 1) { res = x + Math.Pow(Math.Cos(x * x) / (x - 1), x + 3); }
            else if (x == 0) { res = -5; }
            else if (-32 < x && x < -1) { res = Math.Pow(Math.Cos(x) / (Math.PI - x), 2); }
            else { res = x + 10 * x - 7 / x; }
            return Math.Round(res, 3, MidpointRounding.AwayFromZero);
        }
    }
}
