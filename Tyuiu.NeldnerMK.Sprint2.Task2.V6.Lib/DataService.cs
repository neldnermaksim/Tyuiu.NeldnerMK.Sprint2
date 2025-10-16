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

            if ((x == 3 && y == 3) || (x == 4 && y == 3) || (x == 5 && y == 3) || (x == 6 && y == 3) || (x == 9 && y == 3) ||
            (x == 3 && y == 4) || (x == 4 && y == 4) || (x == 5 && y == 4) || (x == 8 && y == 4) || (x == 9 && y == 4) ||
            (x == 3 && y == 5) || (x == 4 && y == 5) || (x == 5 && y == 5) || (x == 6 && y == 5) || (x == 7 && y == 5) || (x == 8 && y == 5) || (x == 9 && y == 5) ||
            (x == 3 && y == 6) || (x == 4 && y == 6) || (x == 5 && y == 6) || (x == 6 && y == 6) || (x == 7 && y == 6) || (x == 8 && y == 6) || (x == 9 && y == 6) ||
            (x == 3 && y == 7) || (x == 4 && y == 7) || (x == 5 && y == 7) || (x == 6 && y == 7) || (x == 7 && y == 7) || (x == 8 && y == 7) || (x == 9 && y == 7) ||
            (x == 4 && y == 8) || (x == 5 && y == 8) || (x == 6 && y == 8) || (x == 7 && y == 8) || (x == 8 && y == 8) ||
            (x == 4 && y == 9) || (x == 5 && y == 9) ||
            (x == 3 && y == 10) || (x == 4 && y == 10) ||
            (x == 3 && y == 11) || (x == 4 && y == 11) || (x == 5 && y == 11) || (x == 6 && y == 11) || (x == 7 && y == 11) || (x == 8 && y == 11) || (x == 9 && y == 11) || (x == 10 && y == 11) ||
            (x == 3 && y == 12) || (x == 4 && y == 12) || (x == 5 && y == 12) || (x == 8 && y == 12) || (x == 9 && y == 12) ||
            (x == 3 && y == 13) || (x == 4 && y == 13) || (x == 9 && y == 13) || (x == 10 && y == 13) ||
            (x == 3 && y == 14) || (x == 4 && y == 14))
            {
                return true;
            }

            return false;






        }
    }
}
