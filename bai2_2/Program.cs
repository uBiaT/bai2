using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
            Console.Write("nhap chieu dai canh a (mm): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("nhap chieu dai canh b (mm): ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
            Console.WriteLine("dien tich hinh chu nhat la {0} (mm2)", a * b);
            Console.WriteLine("chu vi hinh chu nhat la {0} (mm)", (a + b)*2);
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
