using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aritmetikortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            double ortalama = 0;
            int n;
            Console.WriteLine("Kullanıcıdan alınan sayıların ortalamasını bulan program");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Kaç sayıyı toplayacağınızı giriniz:"); 
            n = Convert.ToInt32(Console.ReadLine());
            double[] Dizi = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1)+". Eleman:");
                Dizi[i] = Convert.ToDouble(Console.ReadLine());
                toplam+=Dizi[i];
            }
            ortalama = toplam / n;
            Console.Write("Girdiğiniz sayıların toplamı="+toplam);
            Console.Write("\n---------------------------------------");
            Console.WriteLine("\nGirdiğiniz sayıların ortalamsı: "+ortalama);
            Console.ReadLine();
        }
    }
}
