﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap chieu dai canh a (mm): ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("nhap chieu dai canh b (mm): ");
                double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                double dienTich = a * b;    
                double chuVi = (a + b) * 2;

                Console.WriteLine($"dien tich hinh chu nhat la {dienTich} (mm2)");
                Console.WriteLine($"chu vi hinh chu nhat la {chuVi} (mm)");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
