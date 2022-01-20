using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4 eded verilib (a,b,c,d). bu ededlerin ilk ikisini cemleyib, son ikisinin hasilini tapmaq.
              sonda ise cemi hasile bolmek. ve cavabi ekrana cap etmek ( cem / hasil)
             */
            int a = 16;

            int b = 20;

            int c = 6;

            int d = 3;

            int cem = a + b;
            int hasil = c * d;

            int cavab = cem / hasil;

            Console.WriteLine(cavab);
        }
    }
}
