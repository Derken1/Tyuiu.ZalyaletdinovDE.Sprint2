using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task0.V11.Lib
{
    public class DataService : ISprint2Task0V11
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 7830;
            res[1] = x - 7830 != y;
            res[2] = x < y + 7831;
            res[3] = x - 7831 > y;
            res[4] = x - 7830 <= y;
            res[5] = x - 7831 >= y;

            return res;
        }
    }
}
