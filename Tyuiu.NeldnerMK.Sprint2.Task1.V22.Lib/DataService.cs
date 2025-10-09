using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NeldnerMK.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) & (c > d);
            res[1] = (b != c) | (a == d);
            res[2] = (c <= a) ^ (d >= b) || (b > c);
            res[3] = (a >= b) && (c < d) && !(b == d);
            res[4] = (b > a) & (c < d) | (a == c);
            res[5] = !(c <= a) && (d >= b) || (a == d);

            return res;
        }
    }

}