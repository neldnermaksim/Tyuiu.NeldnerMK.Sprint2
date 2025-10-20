using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NeldnerMK.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (y >= x * x) && (y <= 4) && (x >= -2) && (x <= 2);

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