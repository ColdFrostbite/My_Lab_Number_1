using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            int n;
            int i;
            double Vn;
            double Rs;
            double Vi;
            double pi = 3.14;


            Console.Write("Введите n:  ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите h: ");
            h = Convert.ToDouble(Console.ReadLine());


            Vn = 0;
            Rs = 0;
            for (i = 1; i < n + 1; i++)
            {
                Rs = Rs + (3 * i);
                Vi = (n * pi) * h * i * i;
                Vn = Vn + Vi;
                Console.WriteLine("Цилиндр номер " + i);
                Console.WriteLine(Vi);
            }
            Rs = Rs / n;



            Console.WriteLine("Объем цилиндров равен " + Vn);
            Console.WriteLine("Средний радиус равен = " + Rs);
            Console.ReadLine();
        }
    }
}
