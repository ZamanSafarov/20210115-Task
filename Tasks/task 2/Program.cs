using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ededin 4-e bolunub bolunmediyini cap eden alqoritma yazmali
            int eded = 96;

            if (eded % 4 == 0)
            {
                Console.WriteLine("Bölünür");
            }
            else 
            {
                Console.WriteLine("Bölünmür");
            }
        }
    }
}
