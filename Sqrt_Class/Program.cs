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
            double k = 9, x = k / 2;
            while (x*x != k)
            {
                if (x * x < k)
                {
                    x = x * 3 / 2;
                }
                else
                {
                    x /= 2;
                }
            }
            Console.WriteLine(x);
        }
    }
}
