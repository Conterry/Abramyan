using System;

namespace IF_Top
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void If1()
        {
            int a = 2;
            if (a >= 0)
            {
                a++;
            }
            Console.WriteLine(a);
        }

        static void If2()
        {
            int a = 4;
            if (a >= 0)
            {
                a += 1;
            }
            else
            {
                a -= 2;
            }
            Console.WriteLine(a);
        }

        static void If3()
        {
            int a = 0;
            if (a > 0)
            {
                a++;
            }
            else if (a < 0)
            {
                a -= 2;
            }
            else
            {
                a = 10;
            }
            Console.WriteLine(a);
        }

        static void If4()
        {
            int a = 2, b = -2, c = 5, d = 0;
            if (a >= 0)
            {
                d++;
            }
            if (b >= 0)
            {
                d++;
            }
            if (c >= 0)
            {
                d++;
            }
            Console.WriteLine(d);
        }

        static void If5()
        {
            int a = 4, b = 1, c = -2, p = 0, o = 0;
            if (a >= 0)
            {
                p++;
            }
            if (a < 0)
            {
                o++;
            }
            if (b >= 0)
            {
                p++;
            }
            if (b < 0)
            {
                o++;
            }
            if (c >= 0)
            {
                p++;
            }
            if (c < 0)
            {
                o++;
            }
            Console.WriteLine(p);
            Console.WriteLine(o);
        }

        static void If6()
        {
            int a = 3, b = 8;
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        static void If7()
        {
            int a = 0, b = 1;
            if (a < b)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }

        static void If8()
        {
            int a = 3, b = 8;
            if (a > b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }

        static void If9()
        {
            int a = 4, b = 9;
            if (a < b)
            {
                a = a;
                b = b;
            }
            else
            {
                a = b;
                b = a;
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void If10()
        {
            int a = 3, b = 3;
            if (a == b)
            {
                a = 0;
                b = 0;
            }
            else
            {
                a = a + b;
                b = a + b;
            }
        }

        static void If11()
        {
            int a = 4, b = 6;
            if (a != b)
            {
                a = Math.Max(a, b);
                b = a;
            }
            if (a == b)
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a);
        }

        static void If12()
        {
            int a = 4, b = 9, c = 0;
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            if (c < a && c < b)
            {
                Console.WriteLine(c);
            }
        }

        static void If13()
        {
            int a = 4, b = 5, c = 8;
            if ((b < a && a < c) || (c < a && a < b))
            {
                Console.WriteLine(a);
            }
            if ((a < b && b < c) || (c < b && b < a))
            {
                Console.WriteLine(b);

            }
            if ((a < c && c < b) || (b < c && c < a))
            {
                C
            }
        }
    }
}
