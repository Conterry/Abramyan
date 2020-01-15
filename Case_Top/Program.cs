using System;

namespace Case_Top
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void Case10()
        {
            int a = -1;
            switch (a)
            {
                case 1:
                    Console.WriteLine("В");
                    break;
                case 0:
                    Console.WriteLine("C");
                    break;
                case -1:
                    Console.WriteLine("З");
                    break;
            }
        }

        static void Case11()
        {
            char c = 'N';
            int n1 = 2, n2 = -1;
            WayOut(c, n1);
            WayOut(c, n2);
        }

        static void WayOut(char c, int n)
        {
            switch(c)
            {
                case 'N':
                    switch (n)
                    {
                        case 1:
                            c = 'W';
                            break;
                        case -1:
                            c = 'E';
                            break;
                        case 2:
                            c = 'S';
                            break;
                    }
                    break;
                case 'E':
                    switch (n)
                    {
                        case 1:
                            c = 'N';
                            break;
                        case -1:
                            c = 'S';
                            break;
                        case 2:
                            c = 'W';
                            break;
                    }
                    break;
                case 'S':
                    switch (n)
                    {
                        case 1:
                            c = 'E';
                            break;
                        case -1:
                            c = 'W';
                            break;
                        case 2:
                            c = 'N';
                            break;
                    }
                    break;
                case 'W':
                    switch (n)
                    {
                        case 1:
                            c = 'S';
                            break;
                        case -1:
                            c = 'N';
                            break;
                        case 2:
                            c = 'E';
                            break;
                    }
                    break;
            }
        }
    }
}
