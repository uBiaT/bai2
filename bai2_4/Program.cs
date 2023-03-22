using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
            Console.Write("nhap ho va ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("nhap lop: ");
            string lop = Console.ReadLine();

            Console.Write("nhap diem trung binh HKI: ");
            double diemHKI = double.Parse(Console.ReadLine());

            Console.Write("nhap diem trung binh HKII: ");
            double diemHKII = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
            Console.WriteLine($"ho ten hoc sinh: {hoTen}");
            Console.WriteLine($"lop: {lop}");
            Console.WriteLine($"diem trung binh ca nam: {Math.Round(((diemHKI+ diemHKII*2)/3),1)}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
