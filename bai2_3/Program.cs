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
                Console.Write("nhap duong kinh hinh tron (don vi do dai): ");
                double duongKinh = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                const double pi = Math.PI;
                double banKinh = Math.Round((duongKinh / 2 ), 1);
                double chuVi = Math.Round((banKinh * 2 * pi), 1);
                double dienTich = Math.Round((Math.Pow(banKinh, 2) * pi), 1);

                Console.WriteLine($"ban kinh hinh tron la {banKinh} (don vi do dai)");
                Console.WriteLine($"chu vi hinh tron la {chuVi} (don vi do dai)");
                Console.WriteLine($"dien tich hinh tron la {dienTich} (don vi dien tich)");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
