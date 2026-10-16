using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x == 4 && 2 <= y && y <= 8) | (3 <= x && x <= 7 && y == 6) | (8 <= x && x <= 12 && 5 <= y && y <= 10) | (9 <= x && x <= 12 && 3 <= y && y <= 4) | (x == 13 && 6 <= y && y <= 8) | (6 <= x && x <= 9 && 10 <= y && y <= 11) | (3 <= x && x <= 5 && y == 11) | (7 <= x && x <= 9 && y == 12)) {
                return true;
            } else { return false; }
        }
    }
}
