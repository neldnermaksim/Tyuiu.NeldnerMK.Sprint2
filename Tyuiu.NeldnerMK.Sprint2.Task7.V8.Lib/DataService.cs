using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.NeldnerMK.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result = false;

            // Условие для первой области (0 <= x <= 2)
            if (x >= 0 && x <= 2)
            {
                if (y >= Math.Pow(x, 3) && y <= 4)
                {
                    result = true;
                }
            }
            // Условие для второй области (x > 2)
            else if (x > 2)
            {
                if (y >= 0 && y <= 4)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}