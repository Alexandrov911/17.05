using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.89
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double k = 0;
            if (k < x)
            {
                k = Math.Pow(x, 2);
            }
            else
            {
                k = Math.Abs(x);
            }
            double y = 0;
            if (Math.Sin(x) >= 0)
            {
                y=k*x;
            }
            else
            {
                y = k+x;
            }
            
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
