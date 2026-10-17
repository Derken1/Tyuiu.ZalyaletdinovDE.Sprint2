using Tyuiu.ZalyaletdinovDE.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ZalyaletdinovDE.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Залялетдинов Д. Э. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #2.6                                                            *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Залялетдинов Данил Эдуардович | РППб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным n (число) и m (номер месяца) определить дату следующего дня.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите порядковый номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string res = ds.FindDateOfNextDay(m, n);
                Console.WriteLine($"Дата следующего дня: {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}