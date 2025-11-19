using Tyuiu.MaglevaniyBA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Маглёваный Б. А. | НТм-24-1";


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы по С#                                      *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Маглёваный Богдан Александрович | НТм-24-1                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Найти именя дня по номеру                                              *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int x = int.Parse(Console.ReadLine());
           
            string res = ds.FindDayName(x);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
