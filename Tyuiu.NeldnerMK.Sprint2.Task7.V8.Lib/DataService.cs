using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NeldnerMK.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (y <= 4 && y >= Math.Pow(x, 2) && x >= 0 && x <= 3);

            if (res)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}        