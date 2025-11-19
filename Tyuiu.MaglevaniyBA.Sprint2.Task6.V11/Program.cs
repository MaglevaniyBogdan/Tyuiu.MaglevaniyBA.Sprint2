using Tyuiu.MaglevaniyBA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task6.V11
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
            Console.WriteLine("* Задание #6                                                            *");
            Console.WriteLine("* Вариант #11                                                             *");
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

            int g = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string res = ds.FindDateOfNextDay(g,m,n);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
