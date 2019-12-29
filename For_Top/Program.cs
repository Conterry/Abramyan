using System;

namespace For_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            For5();
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

        static void For3()
        {
            int a = 3, b = 7, n = 0;
            for (int i = b; i >= a; i--, n++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(n);
        }

        static void For4()
        {
            int a = 34;
            for(int i=1; i<11; i++)
            {
                Console.WriteLine(a * i);
            }
        }

        static void For5()
        {
            int a = 23;
            for(float i=0.1f; i<=1; i += 0.1f)
            {
                Console.WriteLine(a * i);
            }
        }

        static void For6()
        {
            int a = 23;
            for (float i = 1.2f; i <= 2; i += 0.2f)
            {
                Console.WriteLine(a * i);
            }
        }

        static void For7()
        {
            int a = 3, b = 7, s = 0;
            for(int i=a; i<=b; i++)
            {
                s += i;
            }
            Console.WriteLine(s);
        }

        static void For8()
        {
            int a = 3, b = 7, s = 0;
            for (int i = a; i <= b; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
        }

        static void For9()
        {
            int a = 3, b = 7, s = 0;
            for (int i = a; i <= b; i++)
            {
                s += i*i;
            }
            Console.WriteLine(s);
        }

        static void For10()
        {
            int n = 5;
            double s = 0;
            for(int i=0; i<n; i++)
            {
                s += 1 / i;
            }
            Console.WriteLine(s);
        }
    }
}
