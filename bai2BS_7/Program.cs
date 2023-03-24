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

            string ho = hoTen.Substring(0, hoTen.IndexOf(" "));
            string ten = hoTen.Substring(hoTen.LastIndexOf(" "), hoTen.Length - hoTen.LastIndexOf(" "));
            string dem = hoTen.Substring(hoTen.IndexOf(" "), hoTen.LastIndexOf(" ") - hoTen.IndexOf(" "));

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"ban vua nhap {soLuong} ky tu");
                Console.WriteLine($"ho: {ho.Trim()}");
                Console.WriteLine($"dem: {dem.Trim()}");
                Console.WriteLine($"ten: {ten.Trim()}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
