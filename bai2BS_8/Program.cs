using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("ten hang hoa: ");
                string tenHang = Console.ReadLine();

                Console.Write("so luong: ");
                int soLuong = int.Parse(Console.ReadLine());

                Console.Write("don gia: ");
                double donGia = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double tongTien = donGia * soLuong * 1.08;

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"so tien ban phai tra la cho {soLuong} {tenHang} la {tongTien}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
