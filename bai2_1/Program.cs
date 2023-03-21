using System;
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
            Console.Write("nhap so nguyen A: ");
            int soA = int.Parse(Console.ReadLine());

            Console.Write("nhap so nguyen B: ");
            int soB = int.Parse(Console.ReadLine());

            Console.WriteLine("<--------------------------------------------------->");

            Console.WriteLine("so nguyen A la {0} va so nguyen B la {1}", soA, soB);
            Console.WriteLine("tong cua so nguyen A va B la {0}", soA + soB);
            Console.WriteLine("hieu cua so nguyen A va B la {0}", soA - soB);
            Console.WriteLine("thuong cua so nguyen A va B la {0}", (double)soA / soB);
            Console.WriteLine("tich cua so nguyen A va B la {0}", soA * soB);

            Console.WriteLine("<--------------------------------------------------->");

            Console.WriteLine("nhap phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
