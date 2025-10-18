using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.NeldnerMK.Sprint2.Task0.V12.Lib;


namespace Tyuiu.NeldnerMK.Sprint2.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #2                                                                *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #12                                                            *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* ННаписать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив)*");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: (True, False, True, False, True, False), при x = 1095, y = 475 ");
            Console.WriteLine();

            int x = 1095;
            int y = 475;


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            bool[] res = ds.GetCompareOperations(x, y);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
