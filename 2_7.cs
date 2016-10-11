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

            // Вычисление Пи по формуле Джона Мэчина


            Console.WriteLine("Введите кол-во знаков после запятой в e");
            int l = int.Parse(Console.ReadLine()), k = 0;
            double e = 1, s1 = 0, s2 = 0, x1 = 1, x2 = 1;
            for (int j = 0; j < l; j++) e /= 10;
            x1 /= 5;
            x2 /= 239;
            while (x1 / (2 * k + 1) > e)
            {
                if (k % 2 == 1)
                {
                    s1 -= x1 / (2 * k + 1);
                    s2 -= x2 / (2 * k + 1);
                }
                else
                {
                    s1 += x1 / (2 * k + 1);
                    s2 += x2 / (2 * k + 1);
                }
                x1 /= 25;
                x2 /= (239 * 239);
                k++;
            }
            Console.WriteLine(16 * s1 - 4 * s2);
            Console.WriteLine(k);
        }
    }
}
