using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint2.Task3.V11.Lib;


namespace Tyuiu.NeldnerMK.Sprint2.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #2                                                                *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else, где пользователь вводит значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой; *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());



            DataService ds = new DataService();
            double res = ds.Calculate(x);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            
            Console.WriteLine(res);
            
        }
    }
}