using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NeldnerMK.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

           
            




        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Множество заштрихованных клеток (X,Y)
        HashSet<(int, int)> shadedCells = new HashSet<(int, int)>
        {
            (3,3), (4,3), (5,3), (6,3), (9,3),
            (3,4), (4,4), (5,4), (8,4), (9,4),
            (3,5), (4,5), (5,5), (6,5), (7,5), (8,5), (9,5),
            (3,6), (4,6), (5,6), (6,6), (7,6), (8,6), (9,6),
            (3,7), (4,7), (5,7), (6,7), (7,7), (8,7), (9,7),
            (4,8), (5,8), (6,8), (7,8), (8,8),
            (4,9), (5,9),
            (3,10), (4,10),
            (3,11), (4,11), (5,11), (6,11), (7,11), (8,11), (9,11), (10,11),
            (3,12), (4,12), (5,12), (8,12), (9,12),
            (3,13), (4,13), (9,13), (10,13),
            (3,14), (4,14)
        };

        Console.Write("Введите X (1–15): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите Y (1–15): ");
        int y = int.Parse(Console.ReadLine());

        if (shadedCells.Contains((x, y)))
        {
            Console.WriteLine("Точка находится в заштрихованной области.");
        }
        else
        {
            Console.WriteLine("Точка вне заштрихованной области.");
        }
    }
}