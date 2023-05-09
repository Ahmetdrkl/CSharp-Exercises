using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kişiselbilgiler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            
            Console.WriteLine("isminizi giriniz:"); string isim = Convert.ToString(Console.ReadLine());
            Console.WriteLine("soyadınızı giriniz:"); string soyad = Console.ReadLine();
            Console.WriteLine("memeleketinizi giriniz:"); string memleket = Console.ReadLine();
            Console.WriteLine("Cinsiyetinizi Giriniz:[E/K]"); char cinsiyet = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Boyunuzu Giriniz:"); int boy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Kilonuzu Giriniz:"); double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kişisel  Bilgiler");
            Console.WriteLine("-------------------------------");
            Console.Write(isim + " " + soyad);
            Console.Write(" - ");
            Console.WriteLine(memleket);
            Console.Write("Cinsiyet :" + " " +cinsiyet);
            Console.Write(" Boy :" + boy + "cm");
            Console.WriteLine(" Kilo :" + kilo + "kg");
            Console.ReadLine();
            const double pi  = 3.14;
            







        }
    }
}
