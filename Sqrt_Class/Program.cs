using System;

namespace SqrtSearch_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Bin();
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
    }
}
