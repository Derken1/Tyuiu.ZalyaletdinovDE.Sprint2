using Tyuiu.ZalyaletdinovDE.Sprint2.Task4.V21.Lib;
namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.Write("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("f(" + x + ", " + y + ") = " + ds.Calculate(x, y));
        }
    }
}
