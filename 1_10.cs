using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            // корень из 1+x


            Console.WriteLine("Введите кол-во знаков после запятой в e");
            int l = int.Parse(Console.ReadLine()), k = 1;
            Console.WriteLine("Введите x, по модулю не превышающий 1");
            double x1, x = double.Parse(Console.ReadLine());
            double s = 1, e = 1, f2 = 1, f = 1, f4 = 1;
            x1 = x;
            for (int j = 0; j < l; j++) e /= 10;
            while (Math.Abs(f2 / ((1 - 2 * k) * f * f4)) > e)
            {
                f2 *= 2 * k * (2 * k - 1);
                f *= k * k;
                f4 *= 4;
                if (k % 2 == 1)
                {
                    s -= (f2 / ((1 - 2 * k) * f * f4)) * x1;
                }
                else
                {
                    s += (f2 / ((1 - 2 * k) * f * f4)) * x1;
                }
                x1 *= x;
                k++;
            }
            Console.WriteLine(s);
            Console.WriteLine(k);
        }
    }
}
