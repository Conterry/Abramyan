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

        static void For11()
        {
            int n = 5;
            double s=0;
            for(int i=0; i<=n; i++)
            {
                s += (n + i) * (n + i);
            }
            Console.WriteLine(s);
        }

        static void For12()
        {
            int n = 5;
            double d = 1;
            for(float i=1.1f, j=1; j<n; i+=0.1f, j++)
            {
                d *= i;
            }
            Console.WriteLine(d);
        }

        static void For13()
        {
            int n = 5;
            double d = 1;
            for (float i = 1.1f, j = 1; j < n; i += 0.1f, j++)
            {
                if (j % 2 == 0)
                {
                    d += i;
                }
                else
                {
                    d -= i;
                }
            }
            Console.WriteLine(d);
        }

        static void For14()
        {
            int n = 5, s = 0;
            for(int i=1; i<2*n; i += 2)
            {
                s += i;
            }
            Console.WriteLine(s);
        }

        static void For15()
        {
            int n = 5;
            double a = 3.5, f=1;
            for(int i=0; i<n; i++)
            {
                f *= a;
            }
            Console.WriteLine(f);
        }

        static void For16()
        {
            int a = 2, n = 5;
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine(Math.Pow(a, i));
            }
        }

        static void For17()
        {
            double a = 2, n = 6, s = 0;
            for(int i=0; i<=n; i++)
            {
                s += Math.Pow(a, i);
            }
            Console.WriteLine(s);
        }

        static void For18()
        {
            double a = 2, n = 5, s = 0;
            for(int i=0; i<=n; i++)
            {
                s += Math.Pow(a * -1, i);
            }
            Console.WriteLine(s);
        }
    }
}
