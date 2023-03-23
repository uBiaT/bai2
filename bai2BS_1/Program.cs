using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap so thu 1: ");
                int so1 = int.Parse(Console.ReadLine());

                Console.Write("nhap so thu 2: ");
                int so2 = int.Parse(Console.ReadLine());

                Console.Write("nhap so thu 3: ");
                int so3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int soLonNhat = Math.Max(Math.Max(so1, so2), so3);

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"so lon nhat la: {soLonNhat}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
