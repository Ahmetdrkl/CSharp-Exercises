using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_sayıya_4_işlem_yaptıran_program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, toplam = 0, çıkarma = 0, çarpma = 0, bölme = 0;
            Console.WriteLine("İKİ SAYIYA 4 İŞLEM YAPTIRAN PROGRAM");
            Console.Write("1. Sayıyı girin:"); a = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayıyı girin:"); b = Convert.ToInt16(Console.ReadLine());
            toplam = a + b;
            çıkarma = a - b;
            çarpma = a * b;
            bölme = a / b;
            Console.WriteLine("Toplama İşleminin Sonucu:"+toplam);
            Console.WriteLine("Çıkarma İşleminin Sonucu:" +çıkarma);
            Console.WriteLine("Çarpma İşleminin Sonucu:" + çarpma);
            Console.WriteLine("Bölme İşleminin Sonucu:" + bölme);
            Console.ReadLine();

        }
    }
}
