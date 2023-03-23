using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap toa do diem A: x(a): ");
                double xA = double.Parse(Console.ReadLine());

                Console.Write("nhap toa do diem A: y(a): ");
                double yA = double.Parse(Console.ReadLine());

                Console.Write("nhap toa do diem B: x(b): ");
                double xB = double.Parse(Console.ReadLine());

                Console.Write("nhap toa do diem B: y(b): ");
                double yB = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double khoangCach = Math.Round(Math.Sqrt(Math.Pow(xB-xA , 2) + Math.Pow(yB - yA , 2)) , 2);

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"khoang cach giua diem A va B la: {khoangCach}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
