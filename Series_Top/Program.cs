using System;

namespace Series_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            Series2();
        }

        static void Series1()
        {
            int[] a = { 2, 4, 7, 3, 6, 8, 6, 3, 6, 8 };
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            Console.WriteLine(s);
        }

        static void Series2()
        {
            int n = 10;
            int[] a = new int[n];
            int s = 0;

            for (int i = 0; i < n; i++)
            {
                a[i] = Console.Read();
                s += a[i];
            }
            Console.WriteLine(s);
        }

        static void Series3()
        {
            int[] a = { 2, 4, 7, 3, 6, 8, 6, 3, 6, 8 };
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            Console.WriteLine(s / 10);
        }

        static void Series4()
        {
            int n = 10;
            int[] a = new int[] { 3, 7, 3, 6, 4, 6, 4, 8, 5, 4 };
            int s = 0, d = 1;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
                d *= a[i];
            }
            Console.WriteLine(s);
            Console.WriteLine(d);
        }

        static void Series5()
        {
            double[] a = { 3.4, 4.5, 5.6, 6.7 };
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int f = (int)a[i];
                s += f;
                Console.WriteLine(f);
            }
            Console.WriteLine(s);
        }

        static void Series6()
        {
            double[] a = { 3.4, 4.5, 5.6, 6.7 };
            double s = 1;
            for (int i = 0; i < a.Length; i++)
            {
                double f = a[i] * 10 % 10;
                s *= f;
                Console.WriteLine(f);
            }
            Console.WriteLine(s);
        }

        static void Series8()
        {
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8 };
            int f = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    f++;
                    Console.WriteLine(a[i]);
                }
            }
        }

        static void Series9()
        {
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8 };
            int f = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    f++;
                    Console.WriteLine(i);
                }
            }
        }

        static void Series10()
        {
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8 };
            int f = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    f++;
                }
            }
            if (f > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Series11()
        {
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8 };
            int f = 0, k = 5;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= k)
                {
                    f++;
                }
            }
            if (f > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Series12()
        {
            int i = 0, f = 0;
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8, 0 };
            while (a[i] != 0)
            {
                f++;
                i++;
            }
            Console.WriteLine(f);
        }

        static void Series13()
        {
            int i = 0, f = 0;
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8, 0 };
            while (a[i] != 0)
            {
                if (a[i] > 0)
                {
                    f+=a[i];
                }
                i++;
                
            }
            if (f > 0)
            {
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static void Series14()
        {
            int i = 0, f = 0, k = 5;
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8, 0 };
            while (a[i] != 0)
            {
                if (a[i] < k)
                {
                    f += a[i];
                }
                i++;

            }
                Console.WriteLine(f);
        }

        static void Series15()
        {
            int i = 0, f = 0, k = 5;
            int[] a = { 2, 5, 3, 6, 8, 4, 4, 2, 5, 6, 8, 1, 4, 8, 0 };
            while (a[i] != 0)
            {
                if (a[i] < k)
                {
                    f += a[i];
                }
                i++;

            }
            if (f > 0)
            {
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine(0);
            }
        }


    }
}
