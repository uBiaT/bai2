using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap chieu cao (cm): ");
                double chieuCao = double.Parse(Console.ReadLine());

                Console.Write("nhap can nang (kg): ");
                double canNang = double.Parse(Console.ReadLine());

                double BMI = Math.Round(canNang / Math.Pow(chieuCao / 100 , 2) , 1);
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"chi so BMI la {BMI}");

                if (BMI < 18.5)
                {
                    Console.WriteLine("-> thieu can");
                }
                else if (18.5 <= BMI & BMI <= 24.9) 
                {
                    Console.WriteLine("-> binh thuong");
                }
                else if (25 <= BMI & BMI <= 29.9)
                {
                    Console.WriteLine("-> thua can");
                }
                else if (30 < BMI)
                {
                    Console.WriteLine("-> beo phi");
                }
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
