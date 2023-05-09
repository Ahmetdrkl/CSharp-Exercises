using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıtahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SAYI TAHMİN OYUNU");
            Console.WriteLine("1-100 Arası sayı tahmin etme oyunu ");
            int sayı = 0,tahmin1=0,tahmin2=0;
            string secim;
            int devam = 0;
           
            while(true)
            {

                Random a = new Random();
                sayı = a.Next(1, 101);
                for (int i = 0;; i++)
                {
             
                    Console.WriteLine("1.Kullanıcı tahmini: ");

                    tahmin1 = kullaniciyaSor();
                    if (tahmin1 != sayı)
                    {
                        if (tahmin1 < sayı)
                            Console.WriteLine("daha büyük bir tahmin yapmalısınız");
                        else if (tahmin1 > sayı)
                            Console.WriteLine("daha kucuk bir tahmin yapmalısınız");
                    }
                    else if (tahmin1 == sayı)
                    {
                        Console.WriteLine("Birinci oyuncu kazandı");
                        break;
                    }
                    Console.WriteLine("2. kullanıcı tahmini: ");
                    tahmin2 = kullaniciyaSor();
                    if (tahmin2 != sayı)
                    {
                        if (tahmin2 < sayı)
                            Console.WriteLine("daha büyük bir tahmin yapmalısınız");
                        else if (tahmin1 > sayı)
                            Console.WriteLine("daha kucuk bir tahmin yapmalısınız");
                    }
                    else if (tahmin2 == sayı)
                    {
                        Console.WriteLine("ikinci oyuncu kazandı");
                        break;
                    }
                }
                Console.WriteLine("Oyuna Devam Etmek İstermisiniz?");
                Console.WriteLine("1-)Evet/2-)Hayır");
                devam = kullaniciyaSor();
                if (devam == 1)
                {
                    continue;
                }
                if (devam == 2)
                {
                    Console.WriteLine("Oyun Sona Ermiştir...");
                    break;
                }                           
            }             
            Console.ReadKey();
        }

       
        static int kullaniciyaSor()
        {
            int girdi = 0;
            try
            {
                girdi = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Lütfen Geçerli Bir Değişken Giriniz.");
                kullaniciyaSor();
            }
            return girdi;
        }
    }
}
