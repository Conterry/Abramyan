using System;

namespace While_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            While27();
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
            double a = 8, b = 3, c = 0;
            while (a >= b)
            {
                c++;
            }
            Console.WriteLine(c);
        }

        static void While3()
        {
            int n = 8, k = 3, d = 0;
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
            int n = 8, k = 1;
            while (k < n)
            {
                k *= 3;
            }

            if (k == n)
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
            while (Math.Pow(2, k) != n)
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
            while (s <= n)
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
            while (s <= n - k)
            {
                s += k;
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(s);
        }

        static void While13()
        {
            double a = 5, k = 1, sum = 0;
            while (sum < a)
            {
                sum += 1 / k;
                k++;
            }
            Console.WriteLine(k);
            Console.WriteLine(sum);
        }

        static void While14()
        {
            double a = 5, k = 1, sum = 0;
            while (sum < a)
            {
                sum += 1 / k;
                k++;
            }
            Console.WriteLine(k - 1);
            Console.WriteLine(sum - 1 / k);
        }

        static void While15()
        {
            double s = 1000, k = 0, p = 5, maxS = 1100;
            while (s < maxS)
            {
                k++;
                s = s + (s / 100 * p);
            }
            Console.WriteLine(k);
            Console.WriteLine(s);
        }

        static void While16()
        {
            double s = 10, k = 0, p = 5, maxS = 200;
            while (s < maxS)
            {
                k++;
                s = s + (s / 100 * p);
            }
            Console.WriteLine(k);
            Console.WriteLine(s);
        }

        static void While17()
        {
            int n = 123456789;
            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
                Console.Write(' ');
            }
        }

        static void While18()
        {
            int n = 123456789, quantity = 0, sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
                quantity++;

            }
            Console.WriteLine(quantity);
            Console.WriteLine(sum);
        }

        static void While19()
        {
            int n = 123456789;
            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
        }

        static void While20()
        {
            int n = 123456789, quantity = 0, sum = 0;
            while (n > 0)
            {
                sum = n % 10;
                n /= 10;
                if (sum == 2) quantity++;

            }
            if (quantity > 0) Console.WriteLine("True");
            if (quantity == 0) Console.WriteLine("False");
        }

        static void While21()
        {
            int n = 123456789, quantity = 0, sum = 0;
            while (n > 0)
            {
                sum = n % 10;
                n /= 10;
                if (sum % 2 != 0) quantity++;

            }
            if (quantity > 0) Console.WriteLine("True");
            if (quantity == 0) Console.WriteLine("False");
        }

        static void While22()
        {
            int n = 36, i = 1, j = 1, count = 0;
            while (i <= n)
            {
                while (j <= n)
                {
                    if (i * j == n) count++;
                    j++;
                }
                i++;
            }
            if (count > 2) Console.WriteLine("False");
            if (count == 2) Console.WriteLine("True");
        }

        static void While24()
        {
            int f1 = 1, f2 = 1, k = 89;
            int a = 0;
            while (f1 < k)
            {
                int rez = f1;
                f1 = f2;
                f2 = rez + f2;
                if (f1 == k)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
            }
            if (a == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void While25()
        {
            int f1 = 1, f2 = 1, k = 88;
            int a = 0;
            while (f1 < k)
            {
                int rez = f1;
                f1 = f2;
                f2 = rez + f2;
            }
            Console.WriteLine(f1);
        }

        static void While26()
        {
            int f1 = 1, f2 = 1, k = 89, rez=0;
            int a = 0;
            while (f1 < k)
            {
                rez = f1;
                f1 = f2;
                f2 = rez + f2;
            }
            Console.WriteLine(rez);
            Console.WriteLine(f2);
        }

        static void While27()
        {
            int f1 = 1, f2 = 1, k = 89, rez = 0, co = 0;
            int a = 0;
            while (f1 < k)
            {
                rez = f1;
                f1 = f2;
                f2 = rez + f2;
                co++;
            }
            Console.WriteLine(co+1);
        }

        //While28()
        //While29()
        //While30()
    }
}
