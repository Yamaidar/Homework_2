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

            // Константа Каталана


            Console.WriteLine("Введите кол-во знаков после запятой в e");
            int l = int.Parse(Console.ReadLine());
            double e = 1, s = 1, k = 1;
            for (int j = 0; j < l; j++) e /= 10;
            while ((1 / ((2 * k + 1) * (2 * k + 1))) > e)
            {
                if (k % 2 == 1)
                {
                    s -= 1 / ((2 * k + 1) * (2 * k + 1));
                }
                else
                {
                    s += 1 / ((2 * k + 1) * (2 * k + 1));
                }
                k++;
            }
            Console.WriteLine(s);
            Console.WriteLine(k);
        }
    }
}
