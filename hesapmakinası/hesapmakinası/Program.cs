using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinası
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0,c = 0,d = 0,e=0,f=0,g=0,ı=0,sonuc = 0;
            while (true)
            {
                Console.WriteLine("Hesap Makinası Uygulaması");
                Console.WriteLine("Yapmak İstediğiniz işlemi Seçiniz:");
                Console.WriteLine("1-) TOPLAMA");
                Console.WriteLine("2-) ÇIKARMA");
                Console.WriteLine("3-) ÇARPMA");
                Console.WriteLine("4-) BÖLME");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Toplamak istediğiniz ilk sayıyı giriniz.");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Toplamak istediğiniz ikinci sayıyı giriniz.");
                    b = Convert.ToInt16(Console.ReadLine());
                    sonuc = (a + b);
                    Console.WriteLine("Toplama işleminizin sonucu:" + sonuc);
                    Console.ReadKey();
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Çıkarmak istediğiniz ilk sayıyı siriniz:");
                    c = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Çıkarmak istediğiniz ikinci sayıyı giriniz.");
                    d = Convert.ToInt16(Console.ReadLine());
                    sonuc = (c - d);
                    Console.WriteLine("Çıkarma iişleminizin sonucu:" + sonuc);
                    Console.ReadLine();
                }
                else if (secim == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Çarpmak istediğiniz ilk sayıyı siriniz:");
                    e = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Çıkarmak istediğiniz ikinci sayıyı giriniz.");
                    f = Convert.ToInt16(Console.ReadLine());
                    sonuc = (e * f);
                    Console.WriteLine("çarpma işleminizin sonucu:" + sonuc);
                    Console.ReadLine();
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Bölmek istediğiniz ilk sayıyı siriniz:");
                    g = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Bölmek istediğiniz ikinci sayıyı giriniz.");
                    ı = Convert.ToInt16(Console.ReadLine());
                    sonuc = (g / ı);
                    Console.WriteLine("bölme işleminizin sonucu:" + sonuc);
                    Console.ReadLine();
                }
            }



        }
    }
}
