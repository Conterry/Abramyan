using System;

namespace Int_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            Int30();
        }

        static void Int1()
        {
            int l = 230;
            l = l / 100;
            Console.WriteLine(l);
        }

        static void Int2()
        {
            int m = 23000;
            m = m / 1000;
            Console.WriteLine(m);
        }

        static void Int3()
        {
            int b = 3072;
            b = b / 1024;
            Console.WriteLine(b);
        }

        static void Int4()
        {
            int a = 15, b = 4;
            a = a / b;
            Console.WriteLine(a);
        }

        static void Int5()
        {
            int a = 15, b = 5;
            a = a % b;
            Console.WriteLine(a);
        }

        static void Int6()
        {
            int a = 23;
            int b = 0;
            b = a % 10;
            a = a / 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Int7()
        {
            int a = 23, b = 0, c = 0, s=0;
            b = a % 10;
            a = a / 10;
            c = a + b;
            s = a * b;
            Console.WriteLine(c);
            Console.WriteLine(s);
        }

        static void Int8()
        {
            int a = 23, b = 0, c = 0, s = 0;
            b = a % 10;
            c = a / 10;
            s = b * 10 + c;
            Console.WriteLine(s);
        }

        static void Int9()
        {
            int a = 134;
            a = a / 100;
            Console.WriteLine(a);
        }

        static void Int10()
        {
            int a = 248, b=0, c=0;
            b = a % 10;
            c = a % 100 / 10;
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        static void Int11()
        {
            int a = 248, b = 0, c = 0, d = 0, s, dob;
            b = a % 10;
            c = a % 100 / 10;
            d = a / 100;
            s = b + c + d;
            dob = b * c * d;
            Console.WriteLine(s);
            Console.WriteLine(dob);
        }

        static void Int12()
        {
            int a = 248, b = 0, c = 0, d = 0, s, dob;
            b = a % 10*100;
            c = a % 100 / 10*10;
            d = a / 100;
            Console.WriteLine(d + c + b);
        }

        static void Int13()
        {
            int a = 248, b = 0, c = 0, d = 0, s, dob;
            b = a % 10;
            c = a % 100 / 10*100;
            d = a / 100 *10;
            Console.WriteLine(b + c + d);
        }

        static void Int14()
        {
            int a = 248, b = 0, c = 0, d = 0, s, dob;
            b = a % 10 *100;
            c = a % 100 / 10;
            d = a / 100*10;
            Console.WriteLine(b + c + d);
        }

        static void Int15()
        {
            int a = 123, b = 0, c = 0, d = 0, s, dob;
            b = a % 10;
            c = a % 100 / 10 * 100;
            d = a / 100 * 10;
            Console.WriteLine(b + c + d);
        }

        static void Int16()
        {
            int a = 123, b = 0, c = 0, d = 0;
            b = a % 10 * 10;
            c = a % 100 / 10;
            d = a / 100 * 100;
            Console.WriteLine(b + c + d);
        }

        static void Int17()
        {
            int a = 242487, b = 0, c = 0, d = 0, s, dob;
            b = a % 1000;
            b = b / 100;
            Console.WriteLine(b);
        }

        static void Int18()
        {
            int a = 242487, b = 0, c = 0, d = 0, s, dob;
            b = a % 10000;
            b = b / 1000;
            Console.WriteLine(b);
        }

        static void Int19()
        {
            int a = 613454, b = 0;
            b = a / 60;
            Console.WriteLine(b);
        }

        static void Int20()
        {
            int a = 613454, b = 0;
            b = a / 3600;
            Console.WriteLine(b);
        }

        static void Int21()
        {
            int a = 613454, b = 0;
            b = a % 60;
            Console.WriteLine(b);
        }

        static void Int22()
        {
            int a = 613454, b = 0;
            b = a % 3600;
            Console.WriteLine(b);
        }

        static void Int23()
        {
            int a = 613454, b = 0;
            b = a / 60;
            b = b % 60;
            Console.WriteLine(b);
        }

        static void Int24()
        {
            int a = 324;
            a = a % 7;
            Console.WriteLine(a);
        }

        static void Int25()
        {
            int a = 324;
            a = a % 7;
            Console.WriteLine(a+4);
        }

        static void Int26()
        {
            int a = 324;
            a = a % 7;
            Console.WriteLine(a+1);
        }

        static void Int27()
        {
            int a = 324;
            a = a % 7;
            Console.WriteLine(a+5);
        }

        static void Int28()
        {
            int a = 324, n = 3;
            a = a % 7;
            Console.WriteLine(a+n-1);
        }

        static void Int29()
        {
            int a = 3, b = 5, c = 4, count=0, a1=0, b1=0, g=0;
            count = (a * b) / (c * c);
            a1 = a % c;
            b1 = b % c;
            g = a1 * b1;
            Console.WriteLine(count);
            Console.WriteLine(g);
        }

        static void Int30()
        {
            int a = 401;
            a = (a + 100) / 100;
            Console.WriteLine(a);
        }
    }
}
