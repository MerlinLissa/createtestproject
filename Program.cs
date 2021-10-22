using System;

namespace liza
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Task
    {
        public static int Power(int number, int exponent)
        {
            int p = number;
            for(int i = 1; i <= exponent; i++)
            {
                p = p * number;
            }
            return p;
        }
    }
}
