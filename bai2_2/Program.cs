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
                Console.Write("nhap chieu dai canh a (don vi chieu dai): ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("nhap chieu dai canh b (don vi chieu dai): ");
                double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                double dienTich = Math.Round(a * b , 1);    
                double chuVi = Math.Round((a + b) * 2 , 1);

                Console.WriteLine($"dien tich hinh chu nhat la {dienTich} (don vi dien tich)");
                Console.WriteLine($"chu vi hinh chu nhat la {chuVi} (don vi chieu dai)");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
