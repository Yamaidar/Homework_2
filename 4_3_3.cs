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

            // Определенный интеграл, задача 3, метод трапеции


            Console.WriteLine("Введите кол-во итераций");
            int n = int.Parse(Console.ReadLine());
            double s = 0, a = 0.5, b = 2.5, h = ((b-a) / n), x = a;
            for (int i = 0; i < n - 1; i++)
            {
                s += ((-Math.Tan(1 / x + x) - Math.Tan(1 / (x + h) + x + h)) * h / 2);
                x += h;
            }
            Console.WriteLine(s);
        }
    }
}
