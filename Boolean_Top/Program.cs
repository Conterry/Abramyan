using System;

namespace Boolean_Top
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool Boolean1()
        {
            int a = 412;
            return a >= 0;
        }

        static bool Boolean2()
        {
            int a = 421;
            return a % 2 != 0;
        }

        static bool Boolean3()
        {
            int a = 4132;
            return a % 2 == 0;
        }

        static bool Boolean4()
        {
            int a = 31, b = 412;
            return a > 2 && b <= 3;
        }

        static bool Boolean5()
        {
            int a = 5, b = 1;
            return a >= 0 || b < -2;
        }

        static bool Boolean6()
        {
            int a = 5, b = 5, c = 1;
            return a < b && b < c;
        }

        static bool Boolean7()
        {
            int a = 4, b = 1, c = 9;
            return (a < b && b < c) || (a > b && b > c);
        }

        static bool Boolean8()
        {
            int a = 5, b = 3;
            return a % 2 != 0 && b % 2 != 0;
        }

        static bool Boolean9()
        {
            int a = 5, b = 3;
            return a % 2 != 0 || b % 2 != 0;
        }

        static bool Boolean11()
        {
            int a = 3, b = 6;
            return (a % 2 == 0 && b % 2 == 0) || (a % 2 != 0 && b % 2 != 0);
        }

        static bool Boolean12()
        {
            int a = 3, b = 5, c = 1;
            return a >= 0 && b >= 0 && c >= 0;
        }

        static bool Boolean13()
        {
            int a = 3, b = 5, c = 1;
            return a >= 0 || b >= 0 || c >= 0;
        }

        static bool Boolean14()
        {
            int a = 4, b = 5, c = 1;
            return (a >= 0 && b < 0 && c < 0) || (a < 0 && b >= 0 && c < 0) || (a < 0 && b < 0 && c >= 0);
        }

        static bool Boolean15()
        {
            int a = 4, b = 5, c = 1;
            return (a >= 0 && b >= 0 && c < 0) || (a < 0 && b >= 0 && c >= 0) || (a >= 0 && b < 0 && c >= 0);
        }

        static bool Boolean16()
        {
            int a = 123;
            return a % 2 == 0 && a < 100 && a > 9;
        }

        static bool Boolean17()
        {
            int a = 123;
            return a % 2 != 0 && a > 99 && a < 1000;
        }

        static bool Boolean18()
        {
            int a = 3, b = 6, c = 2;
            return a == b || b == c || a == b;
        }

        static bool Boolean19()
        {
            int a = 3, b = 5, c = -3;
            return Math.Abs(a) == Math.Abs(b) || Math.Abs(a) == Math.Abs(c) || Math.Abs(b) == Math.Abs(c);
        }

        static bool Boolean20()
        {
            int a = 523, c = 0, b = 0, d = 0;
            b = a / 100;
            c = a % 100 / 10;
            d = a % 10;
            return a != b && a != c && b != c;
        }

        static bool Boolean21()
        {
            int a = 523, c = 0, b = 0, d = 0;
            b = a / 100;
            c = a % 100 / 10;
            d = a % 10;
            return a < b && b < c;
        }

        static bool Boolean22()
        {
            int a = 523, c = 0, b = 0, d = 0;
            b = a / 100;
            c = a % 100 / 10;
            d = a % 10;
            return (a < b && b < c) || (a > b && b > c);
        }

        static bool Boolean23()
        {
            int a = 1221, b = 0, c = 0, d = 0, g = 0;
            b = a / 1000;
            c = a / 100 % 10;
            d = a % 100 / 10;
            g = a % 10;
            return a == g && b == c;
        }

        static bool Boolean24()
        {
            int a = 1, b = 4, c = 6;
            double d = 0;
            d = b * b - 4 * a * c;
            return b >= 0;
        }

        static bool Boolean25()
        {
            int x = -3, y = 3;
            return x < 0 && y >= 0;
        }

        static bool Boolean26()
        {
            int x = -2, y = 6;
            return x >= 0 && y < 0;
        }

        static bool Boolean27()
        {
            int x = 5, y = 7;
            return (x < 0 && y >= 0) || (x < 0 && y < 0);
        }

        static bool Boolean28()
        {
            int x = 5, y = 8;
            return (x >= 0 && y >= 0) || (x < 0 && y < 0);
        }

        static bool Boolean29()
        {
            int x = 3, y = 6, x1 = -3, y1 = -4, x2 = 5, y2 = -4;
            return x < x1 && x > x2 && y1 > y && y > y2;
        }

        static bool Boolean30()
        {
            int a = 4, b = 4, c = 4;
            return a == b && b == c;
        }

        static bool Boolean31()
        {
            int a = 4, b = 4, c = 7;
            return a == b || b == c || a == c;
        }

        static bool Boolean32()
        {
            int a = 44, b = 2, c = 8;
            return a * a + b * b == c * c || a * a == b * b + c * c || a * a + c * c == b * b;
        }

        static bool Boolean33()
        {
            int a = 4, b = 7, c = 1;
            return a + b > c || a < b + c || a + c > b;
        }

        static bool Boolean34()
        {
            int x = 4, y = 1;
            return (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
        }

        static bool Boolean35()
        {
            int x1 = 5, y1 = 7, x2 = 9, y2 = 1;
            return ((x1 % 2 == 0 && y1 % 2 != 0) || (x1 % 2 != 0 && y1 % 2 == 0)) && ((x2 % 2 == 0 && y2 % 2 != 0) || (x2 % 2 != 0 && y2 % 2 == 0));
        }

        static bool Boolean36()
        {
            int x1 = 5, y1 = 7, x2 = 9, y2 = 1;
            return x1 == x2 || y1 == y2;
        }

        static bool Boolean37()
        {
            int x1 = 5, y1 = 7, x2 = 9, y2 = 1;
            return Math.Abs(x1 - x2) == 1 || Math.Abs(y1 - y2) == 1 || (Math.Abs(y1 - y2) == 1) && (Math.Abs(x1 - x2) == 1);
        }

        static bool Boolean38()
        {
            int x1 = 5, y1 = 7, x2 = 9, y2 = 1;
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        static bool Boolean39()
        {
            int x1 = 5, y1 = 7, x2 = 9, y2 = 1;
            return x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }

        static bool Boolean40()
        {
            int x1 = 5, y1 = 7, x2 = 9, y2 = 1;
            return Math.Abs(x1 - x2) == 3 && Math.Abs(y1 - y2) == 1;
        }
    }
}
