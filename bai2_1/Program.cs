﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

using System.Threading.Tasks;

namespace bai2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("nhap so nguyen A: ");
                int soA = int.Parse(Console.ReadLine());

                Console.Write("nhap so nguyen B: ");
                int soB = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("<----------------------OUTPUT--------------------->");
                int tong = soA + soB;
                int hieu = soA - soB;
                int tich = soA * soB;
                double thuong = Math.Round((double)soA / soB,1);

                Console.WriteLine($"tong cua so nguyen A va B la: {tong}");
                Console.WriteLine($"hieu cua so nguyen A va B la: {hieu}");
                Console.WriteLine($"tich cua so nguyen A va B la: {tich}");
                Console.WriteLine($"thuong cua so nguyen A va B la: {thuong}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
