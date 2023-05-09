using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = 0;
            Console.WriteLine("Kaç elemanlı bir fibonacci sayı dizisi istersiniz: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] A = new int[n];
            A[0] = 1; A[1] = 1;
            for (int i =2; i<n; i++)          
                A[i] = A[i - 1] + A[i - 2];           
            for (int i = 0; i < n; i++)           
                Console.Write(A[i]+"~");
                Console.ReadLine();
            */

            int n = 0;
            Console.WriteLine("kaç elemanlı fibonacci dizisi istersiniz: ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] A = new int[n];
            A[0] = 1; A[1] = 1;
            for (int i = 2; i < n; i++)
                A[i] = A[i - 1] + A[i - 2];
            for (int i = 0; i < n; i++)
                Console.Write(A[i]+"-");
                Console.ReadLine();
        }
    }
}
