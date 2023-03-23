using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2BS_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap ten ngan hang: ");
                string tenNH = Console.ReadLine();

                Console.Write("nhap so tien gui (vnd): ");
                double tienGui = double.Parse(Console.ReadLine());

                Console.Write("nhap lai suat (%): ");
                double laiSuat = double.Parse(Console.ReadLine());

                Console.Write("nhap thoi gian gui (thang): ");
                double thoiGian = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double tienLai = (laiSuat/12 * thoiGian)/100 * tienGui;
            double tienTong = tienGui + tienLai;

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                Console.WriteLine($"lai suat gui tiet kiem tai Ngan Hang {tenNH}:");
                Console.WriteLine($"so tien nhan duoc sau {thoiGian} thang la: {tienTong} (vnd)");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
