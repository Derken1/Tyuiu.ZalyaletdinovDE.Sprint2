using Tyuiu.ZalyaletdinovDE.Sprint2.Task5.V1.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.Write("Введите номер месяца: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("В этом месяце " + ds.FindMonthDaysCount(x) + " дней");
        }
    }
}
