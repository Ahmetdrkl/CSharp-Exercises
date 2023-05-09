using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klavyeden_girilen_3_sayının_en_büyüğünü_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            double birinci=0, ikinci=0, üçüncü =0;
            Console.WriteLine("Kullanıcıdan ALınan 3 Sayının En Büyüğünü Bulan Program");
            Console.WriteLine("Birinci Sayıyı Giriniz:"); birinci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz:"); ikinci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Üçünci Sayıyı Giriniz:"); üçüncü = Convert.ToDouble(Console.ReadLine());
            if (birinci < ikinci && üçüncü < ikinci) Console.WriteLine("En Büyük Sayı İkinci Girdiğiniz Sayıdır");
            else if (ikinci < birinci && üçüncü < birinci) Console.WriteLine("En Büyük Sayı Birinci Girdiğiniz Sayıdır");
            else Console.WriteLine("En Büyük Sayı Üçüncü Girdiğiniz Sayıdır");
            Console.ReadLine();
        }
    }
}
