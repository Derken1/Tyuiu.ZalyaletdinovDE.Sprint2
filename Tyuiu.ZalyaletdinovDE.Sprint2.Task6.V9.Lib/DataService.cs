using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => throw new ArgumentException("Номер месяца должен быть от 1 до 12")
            };

            if (n < 1 || n > daysInMonth)
            {
                throw new ArgumentException("Указан некорректный день для данного месяца");
            }

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                m++;
            }

            return $"{n}.{m}";
        }
    }
}
