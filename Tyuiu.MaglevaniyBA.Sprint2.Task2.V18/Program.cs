using Tyuiu.MaglevaniyBA.Sprint2.Task2.V18.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task2.V18
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
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Маглёваный Богдан Александрович | НТм-24-1                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* вычисляет математическое выражение по исходным значениям данных,       *");
            Console.WriteLine("* вводимых пользователем.                                                *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x,y);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
