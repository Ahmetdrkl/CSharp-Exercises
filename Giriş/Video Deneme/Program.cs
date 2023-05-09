using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kişiselbilgiödevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsminizi Giriniz:"); string isim = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz:"); string soyad = Console.ReadLine();
            Console.Write("Nerelisiniz:"); string memleket = Console.ReadLine();
            Console.Write("Cinsiyetiniz [E/K]:"); char cinsiyet = Convert.ToChar(Console.ReadLine());
            Console.Write("Boyunuz:"); int boy = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kilonuz:"); double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kişisel Bilgiler");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(isim + " " + soyad + "  -  " + memleket);
            Console.Write("Cinsiyet : " + cinsiyet);
            Console.Write("  Boy : " + boy + "cm");
            Console.WriteLine("  Kilo : " + kilo + "kg");
            Console.ReadLine();
        }
    }
}
