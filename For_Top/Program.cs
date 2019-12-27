using System;

namespace For_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            For2();
        }

        static void For1()
        {
            int n=3, k=4;
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(k);
            }
        }

        static void For2()
        {
            int a=3, b=7, n=0;
            for(int i=a; i<=b; i++, n++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(n);
        }
    }
}
