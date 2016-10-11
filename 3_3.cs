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

            // Вычисление Пи по алгоритму Гаусса-Лежандра


            Console.WriteLine("Введите кол-во знаков после запятой в e");
            int l = int.Parse(Console.ReadLine()), k = 0;
            double a0 = 1, b0 = 1 / Math.Sqrt(2), t0 = 0.25, p0 = 1, e = 1;
            double an = (a0 + b0) / 2, bn = Math.Sqrt(a0 * b0), tn = t0 - p0 * (a0 - an) * (a0 - an), pn = 2 * p0;
            for (int j = 0; j < l; j++) e /= 10;
            while (an - bn > e)
            {
                a0 = an;
                b0 = bn;
                t0 = tn;
                p0 = pn;
                an = (a0 + b0) / 2;
                bn = Math.Sqrt(a0 * b0);
                tn = t0 - p0 * (a0 - an) * (a0 - an);
                pn *= 2;
            }
            Console.WriteLine((an + bn) * (an + bn) / (4 * tn));
        }
    }
}
