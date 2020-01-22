using System;

namespace For_Top
{
    class Program
    {
        static void Main(string[] args)
        {
            For39();
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
                s += 1.0 / i;
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

        static void For19()
        {
            double d = 5, s = 1;
            for(int i=1; i<=d; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
            
        }

        static void For20()
        {
            double n = 5, s = 0, d = 1;
            for(int i=1; i<=n; i++)
            {
                d *= i;
                s += d;
            }
            Console.WriteLine(s);
        }

        static void For21()
        {
            double n = 5, s = 0, d = 1;
            for (int i = 1; i <= n; i++)
            {
                d *= i;
                s += 1/d;
            }
            Console.WriteLine(s);
        }

        static void For22()
        {
            double n = 5, s = 0, d = 1, f=1, x=5;
            for (int i = 1; i <= n; i++)
            {
                f *= x;
                d *= i;
                s += f/d;
            }
            Console.WriteLine(s);
        }

        //static void For23()
        //{
        //    int x = 5, n = 5, s = 0, d = 1, m = 1; ;
        //    for(int i=0; i<n; i++)
        //    {
        //        d *= i;
        //        m *= -1;
        //        s += m * d;
        //    }
        //    Console.WriteLine(s);
        //}

        static void For24()
        {
            double n = 5, x = 5, sum = 0, stx = 0, fac = 1, sto = 1;
            for (int i=1; i<=n; i+=2, fac*=i, fac*=i-1, sto*=-1, stx*=x, stx*=x)
            {
                sum+=sto*stx/ fac;
            }
            Console.WriteLine(sum);
        }

        static void For25()
        {
            double x = 5, n = 5, sum = 0, stx = x, sto = 1;
            for(int i=1; i<=n; i++, stx*=x, sto*=-1)
            {
                sum += sto * stx / i;
            }
            Console.WriteLine(sum);
        }

        static void For26()
        {
            double n = 5, x = 5, stx = x, f = 1, sto = 1, sum = 0;
            for(int i=1; i<n; i++, f+=2, stx*=x, stx *= x, sto*=-1)
            {
                sum += sto * stx / f;
            }
            Console.WriteLine(sum);
        }

        static void For29()
        {
            double a = 2, b = 6, n = 2, h, f, sum = 0;
            h = b - a / n;
            Console.WriteLine(b - a / n);
            int i = 1;
            while (sum < b)
            {
                sum = a + i * h;
                Console.WriteLine(sum);
                i++;
            }
        }

        static void For30()
        {
            double a = 2, b = 6, n = 3, h, f, sum = 0;
            h = b - a / n;
            Console.WriteLine(h);
            int i = 1;
            while (sum < b)
            {
                sum = a + i * h;
                Console.WriteLine(1 - Math.Sin(sum));
                i++;
            }   
        }

        static void For31()
        {
            double n = 5, a = 2;
            Console.WriteLine(a);
            for(int i=0; i<n; i++)
            {
                a = 2 + 1 / a;
                Console.WriteLine(a);
            }
        }

        static void For32()
        {
            double n = 5, a = 1;
            Console.WriteLine(a);
            for (int i = 1; i <= n; i++)
            {
                a = (a+1)/i;
                Console.WriteLine(a);
            }
        }

        static void For33()
        {
            int n = 6;
            int f1 = 1;
            int f2 = 1;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 3; i < n; i++)
            {
                int r = f1;
                f1 = f2;
                f2 = r+f2;
                Console.WriteLine(f2);
            }
        }

        static void For34()
        {
            int n = 6;
            int f1 = 1;
            int f2 = 2;
            for (int i = 3; i < n; i++)
            {
                int r = f1;
                f1 = f2;
                f2 = (r + 2*f2)/3;
                Console.WriteLine(f2);
            }
        }

        static void For35()
        {
            int n = 6;
            int f1 = 1;
            int f2 = 2;
            int f3 = 3;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            for (int i = 3; i < n; i++)
            {
                int f4 = f3 + f2 - 2 * f1;
                Console.WriteLine(f4);
                f1 = f2;
                f2 = f3;
                f3 = f4;
            }
        }

        static void For36()
        {
            double n = 5, k = 5, f, s=0;
            for(int i=1; i<=n; i++)
            {
                f = i;
                for(int j=1; j<=k; j++)
                {
                    f *= i;
                }
                s += f;
            }
            Console.WriteLine(s);
        }

        static void For37()
        {
            double n = 5, s = 0;
            for(double i=1; i<=n; i++)
            {
                s += Math.Pow(i, i) ;
            }
            Console.WriteLine(s);
        }

        static void For38()
        {
            double n = 5, s = 0;
            for(int i=0, j=1; i<n; i++, j++)
            {
                s += Math.Pow(j, n - i);
            }
            Console.WriteLine(s);
        }

        static void For39()
        {
            int a = 3, b = 6;
            for(int i=a; i < b; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void For40()
        {
            int a = 4, b = 6, k=1;
            for (int i = a; i < b; i++, k++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
