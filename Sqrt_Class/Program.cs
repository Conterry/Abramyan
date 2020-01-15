using System;

namespace SqrtSearch_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            gg();
        }

        static void Bin()
        {
            double k = 9, a = 0, b = k, avg=0;
            while (b - a > 0.0001)
            {
                avg = (a + b) / 2;
                if (avg * avg < k)
                {
                    a = avg;
                }
                else
                {
                    b = avg;
                }
            }
            Console.WriteLine(avg);
        }

        static void gg()
        {
            int j = 0;
            while (j < 250)
            {
                j++;
                if (j % 5 == 0)
                {
                    Console.Clear();
                    Random rand2 = new Random();
                    int hh = rand2.Next(0, 40);
                    Console.Write(hh);
                    Console.WriteLine(" см");
                }

            }
        }
    }
}
