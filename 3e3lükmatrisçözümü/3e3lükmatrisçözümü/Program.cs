
using System;

namespace _3e3lükmatrisçözümü
{
    class Program
    {
        static void Main(string[] args)
        {
            /* "2lik"
            //Tanımlar
            int[,] A = new int[2, 2];
            int i = 0, j = 0, detA;
            //Matris elemanları alınır 
            Console.WriteLine("Matris elemanları giriniz");
            for(i=0;  i<2; i++)
                for (j=0;j<2;++j)
            {
                Console.Write("A[{0},{1}]",i,j);
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("A matrisi");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; ++j)
                    Console.Write("{0} ",A[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();            */
            int[,] A = new int[3,3]; int i = 0, j = 0, detA; 
            Console.WriteLine("Matris elemanları giriniz");
            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; ++j)
                {
                    Console.Write("A[{0},{1}]", i, j);
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            Console.WriteLine("A matrisi: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; ++j)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            detA = ((A[0, 0] * A[1, 1] * A[2, 2])
                  + (A[1, 0] * A[2, 1] * A[0, 2])
                  + (A[2, 0] * A[0, 1] * A[1, 2]))
                  -
                   ((A[0, 2] * A[1, 1] * A[2, 0])
                  + (A[1, 2] * A[2, 1] * A[0, 0])
                  + (A[2, 2] * A[0, 1] * A[0, 1]));
            Console.WriteLine("Matrisin Determinantı: "+detA);
            Console.ReadLine();
            



        }
    }
}
