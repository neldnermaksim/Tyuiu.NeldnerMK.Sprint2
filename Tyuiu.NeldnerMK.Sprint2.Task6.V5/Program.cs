// Seeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NeldnerMK.Sprint2.Task6.V5.Lib;


namespace Tyuiu.NeldnerMK.Sprint2.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №1 | Выполнил: Нельднер М. К . | СМАРТб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт  #2                                                                *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Нельднер Максим Константинович | СМАРТб-25-1                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям («шестерка», «девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство соответствующей карты.\r\n\r\n *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine();

            Console.Write("Введите номер карты: ");
            int value = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            string res = ds.FindCardValue(value);


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine(res);

        }
    }
}