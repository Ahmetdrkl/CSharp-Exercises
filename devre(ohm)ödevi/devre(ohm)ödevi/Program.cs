using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devre_ohm_ödevi
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1 , R2, R3, V, Reş, I, I1, I2, V1, V2 = 0;
            Console.WriteLine("V Değerini Giriniz:"); V = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("R1 Değerini Giriniz:"); R1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("R2 Değerini Giriniz:"); R2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("R3 Değerini Giriniz:"); R3 = Convert.ToDouble(Console.ReadLine());
            Reş = R1 + (R2 * R3) / (R2 + R3);
            I = V / Reş;
            V1 = I * R1;
            V2 = I * (R2 * R3) / (R2 + R3);
            I1 = V1 / R2;
            I2 = V2 / R3;
            Console.WriteLine("I Değeri:{0}", I);
            Console.WriteLine("Reş Değeri:{0}", Reş);
            Console.WriteLine("V1 Değeri:{0}", V1);
            Console.WriteLine("V2 Değeri:{0}", V2);
            Console.WriteLine("I1 Değeri:{0}", I1);
            Console.WriteLine("I2 Değeri:{0}", I2);
            Console.ReadLine();


        }
    }
}
