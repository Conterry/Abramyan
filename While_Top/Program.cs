using System;

namespace While_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            While11();
            While12();
        }

        static void While1()
        {
            double a = 8, b = 3;
            while (a >= b)
            {
                a -= b;
            }
            Console.WriteLine(a);
        }

        static void While2()
        {
            double a = 8, b = 3, c=0;
            while (a >= b)
            {
                c++;
            }
            Console.WriteLine(c);
        }

        static void While3()
        {
            int n = 8, k = 3, d=0;
            while (n >= k)
            {
                d++;
                n = n - k;
            }
            Console.WriteLine(d);
            Console.WriteLine(n);
        }

        static void While4()
        {
            int n = 8, k=1;
            while (k<n)
            {
                k *= 3;
            }

            if(k==n)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void While5()
        {
            int n = 1024, k = 1;
            while(Math.Pow(2, k) != n)
            {
                k++;
            }
            Console.WriteLine(k);
        }

        static void While6()
        {
            double n = 25, i = 0, s = 1;
            do
            {
                i += 2;
                s *= n - i;
                Console.WriteLine(n - i);
            } while (n - i >= 3);
            Console.WriteLine(s);
        }

        //While7()
        //While8()

        static void While9()
        {
            double n = 28, k = 0;
            while (Math.Pow(3, k) < n)
            {
                k++;
            } 
            Console.WriteLine(k);
        }

        static void While10()
        {
            double n = 70, k = 0;
            while (Math.Pow(3, k) < n / 3)
            {
                k++;
            }
            Console.WriteLine(k);
        }

        static void While11()
        {
            double n = 70, k = 1, s = 0;
            while (s<=n)
            {
                s += k;
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(s);
        }

        static void While12()
        {
            double n = 70, k = 1, s = 0;
            while (s <= n-k)
            {
                s += k;
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(s);
        }
    }
}
