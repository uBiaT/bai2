using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap so nguyen: ");
                int soNguyen = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("<----------------------OUTPUT--------------------->");
                if (soNguyen % 2 == 0)
                {
                    Console.WriteLine($"{soNguyen} la so Chan");
                }
                else
                {
                    Console.WriteLine($"{soNguyen} la so Le");
                }
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
