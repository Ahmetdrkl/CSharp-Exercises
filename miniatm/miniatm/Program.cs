using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniatm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 10000;
            int cekilecektutar;
            Console.WriteLine("KYK BANKA HOŞGELDİNİZ");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1-BAKİYE SORGULAMA");
            Console.WriteLine("2-PARA ÇEKME");
            Console.WriteLine("3-PARA YATIRMA");
            Console.WriteLine("4-ÇIKIŞ");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Bakiyeniz: " + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {

                Console.WriteLine("çekmek istediğiniz tutarı giriniz: "); cekilecektutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecektutar <= bakiye)
                {
                    Console.WriteLine("Bakiyenizde kalan tutar: " + (bakiye - cekilecektutar));
                    
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla tutar çekemezsiniz Lütfen geçerli giriş yapınız.");
                    Console.ReadLine();
                }
            }
            else if (secim == "3")

            {
                int yatırılacaktutar ;
                Console.WriteLine("yatrırmak istediğiniz tutarı giriniz");
                yatırılacaktutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bakiyenizdeki tutar " + (bakiye + yatırılacaktutar));
                Console.ReadLine();
            }
            else if (secim == "4")
            {
                Console.WriteLine("CİKİŞ YAPILIYORRRRR.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("geçerli bir karakteri tuşlaytınız.");
                Console.ReadLine();
            }
            Console.ReadKey();


        }
    }
}
