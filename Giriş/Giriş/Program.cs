using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş
{
    class Program
    {
        static void Main(string[] args)
        {
            double Amper, Volt , Ohm = 0;
            Console.WriteLine("Amper Hesaplama Uygulaması");
            Console.Write("Volt Değeri Giriniz:"); Volt = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ohm Değeri Giriniz:"); Ohm = Convert.ToInt16(Console.ReadLine());
            Amper = (Volt / Ohm);
            Console.WriteLine("Amper Değeriniz:"+Amper);
            Console.ReadLine();









        }
    }
}
