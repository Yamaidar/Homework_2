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

            // Определенный интеграл, задача 5, метод Монте-Карло


            Console.WriteLine("Введите кол-во итераций");
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            double s = 0, a = 1, b = 3, h = ((b - a) / n), x = a; Console.WriteLine("      " + h);
            for (int i = 0; i < n - 1; i++)
            {
                x = a + h * r.Next(n);
                Console.WriteLine(x);
                s += h * Math.Cos(Math.Sin(x));
            }
            Console.WriteLine(s);
        }
    }
}
