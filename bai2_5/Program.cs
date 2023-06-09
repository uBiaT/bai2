﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct nhanVien
{
    public string hoTen;
    public string gioiTinh;
    public string ngaySinh;
    public int soNam;
    public double heSoLuong;
    public double luongCoBan;
}

namespace bai2_5
{
    internal class Program
    {
        static void NhapThongTin(out nhanVien nv)
        {
            Console.Write("nhap ho va ten: ");
            nv.hoTen = Console.ReadLine();

            Console.Write("nhap gioi tinh: ");
            nv.gioiTinh = Console.ReadLine();

            Console.Write("nhap ngay sinh: ");
            nv.ngaySinh = Console.ReadLine();

            Console.Write("nhap so nam lam viec: ");
            nv.soNam = int.Parse(Console.ReadLine());

            Console.Write("nhap he so luong: ");
            nv.heSoLuong = double.Parse(Console.ReadLine());

            Console.Write("nhap luong co ban: ");
            nv.luongCoBan = double.Parse(Console.ReadLine());
        }
        static void XuatThongTin(nhanVien nv)
        {
            Console.WriteLine($"nhan vien: {nv.hoTen}");

            Console.WriteLine($"gioi tinh: {nv.gioiTinh}");

            Console.WriteLine($"ngay sinh: {nv.ngaySinh}");

            Console.WriteLine($"so nam lam viec: {nv.soNam}");

            Console.WriteLine($"he so luong: {nv.heSoLuong}");

            Console.WriteLine($"luong co ban: {nv.luongCoBan}");

            if (nv.soNam > 5)
            {
                Console.WriteLine($"phu cap: {nv.luongCoBan * 0.5}");
            }
            else
            {
                Console.WriteLine($"phu cap: {0}");
            }
        }
        static void Main(string[] args)
        {
            nhanVien NV1 = new nhanVien();
            nhanVien NV2 = new nhanVien();
            Console.WriteLine("<----------------------INPUT---------------------->");
                NhapThongTin(out NV1);
            Console.WriteLine();
                NhapThongTin(out NV2);
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                XuatThongTin(NV1);
            Console.WriteLine();
                XuatThongTin(NV2);
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey(); 
        }
        
    }
}
