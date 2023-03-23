using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap ngay: ");
                int ngay = int.Parse(Console.ReadLine());

                Console.Write("nhap thang: ");
                int thang = int.Parse(Console.ReadLine());

                Console.Write("nhap nam: ");
                int nam = int.Parse(Console.ReadLine());

                DateTime ngayThangNam = new DateTime(nam, thang, ngay);
            Console.WriteLine();

            string ngayTruoc = (ngayThangNam.AddDays(-1)).ToString("dd/MM/yyyy");
            string ngayChon = ngayThangNam.ToString("dd/MM/yyyy");
            string ngaySau = (ngayThangNam.AddDays(1)).ToString("dd/MM/yyyy");

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"ngay hom truoc la: {ngayTruoc}");
                Console.WriteLine($"ngay ban chon la: {ngayChon}");
                Console.WriteLine($"ngay hom sau la: {ngaySau}");
            Console.WriteLine();

            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap so ngay ban muon them/bot: ");
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());
            string ngayCan = (ngayThangNam.AddDays(n)).ToString("dd/MM/yyyy");

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"ngay ban can la: {ngayCan}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
