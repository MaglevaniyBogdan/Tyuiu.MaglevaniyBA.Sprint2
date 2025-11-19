using Tyuiu.MaglevaniyBA.Sprint2.Task4.V9.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint2.Task4.V9
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
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Вариант #9                                                             *");
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

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double res = ds.Calculate(x,y);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
