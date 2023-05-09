using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faaktöriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktoriyelini hesaplamak istediğiniz sayıyı giriniz: ");
            int faktoriyel = 1, sayı;
            sayı = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i <= sayı; i++) faktoriyel = faktoriyel * i;
            Console.Write("{0}!={1}", sayı, faktoriyel);
            Console.ReadLine();

        }      
    }
}
