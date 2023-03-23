using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap nhiet do (do C): ");
                double doC = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double doF = (doC * 1.8) + 32;

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"nhiet do (do F) la: {doF}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
