using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap duong kinh hinh tron (d) (mm): ");
                double d = double.Parse(Console.ReadLine());
                double r = d / 2;
                const double pi = Math.PI;
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine("ban kinh hinh tron (r) la {0} (mm)", r);
                Console.WriteLine("chu vi hinh tron (C) la {0} (mm)", Math.Round(r * 2 * pi,2));
                Console.WriteLine("dien tich hinh tron (S) la {0} (mm2)", Math.Round(Math.Pow(r,2) * pi,2));
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
