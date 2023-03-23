using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap ho ten: ");
                string hoTen = Console.ReadLine();
            Console.WriteLine();

            int soLuong = hoTen.Length;

            hoTen = hoTen.Trim();

            string[] tachChuoi = hoTen.Split(' ');
            Console.WriteLine(tachChuoi.Length); 

            string ho = tachChuoi.First();
            string ten = tachChuoi.Last();
            string dem = "";

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"ban vua nhap {soLuong} ky tu");
                Console.WriteLine($"ho: {ho}");
                Console.WriteLine($"dem: {dem}");
                Console.WriteLine($"ten: {ten}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
