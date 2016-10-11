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

            // Косинус от x


            Console.WriteLine("Введите кол-во знаков после запятой в e");
            int l = int.Parse(Console.ReadLine()), k = 1;
            Console.WriteLine("Введите x");
            double x1, x = double.Parse(Console.ReadLine());
            x1 = x * x;
            double s = 1, e = 1;
            long f = 1;
            for (int j = 0; j < l; j++) e /= 10;
            while (x / f > e)
            {
                f *= 2 * k * (2 * k - 1);
                if (k % 2 == 1)
                {
                    s -= x1 / f;
                }
                else
                {
                    s += x1 / f;
                }
                k++;
                x1 *= x * x;
            }
            Console.WriteLine(s);
            Console.WriteLine(k);
        }
    }
}
