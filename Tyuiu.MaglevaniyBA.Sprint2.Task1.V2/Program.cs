using Tyuiu.MaglevaniyBA.Sprint2.Task1.V2.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task1.V2
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

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
