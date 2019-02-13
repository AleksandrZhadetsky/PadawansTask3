using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {

        public static int Gcd(int a, int b)
        {
            if (a==0 & b==0)
            {
                throw new ArgumentException();
            }
            if (a==0)
            {
                return b;
            }
            if (b==0)
            {
                return a;
            }
            if (a==1 || b==1)
            {
                return 1;
            }
            if (a==b)
            {
                return a;
            }

            //Euclid method

            int left = a, right = b;
            while (left != 0 & right != 0)
            {
                if (left > right)
                {
                    left = left % right;
                }
                else
                {
                    right = right % left;
                }
            }
            return left + right;

            // alternative algorithm below

            //int x = 1;
            //int min = a < b ? a : b;
            //int max = a < b ? b : a;
            //int r = 0;
            //int gcd = 0;
            //do
            //{
            //    while (max - (x * min) >= min)
            //    {
            //        x++;
            //    }
            //    r = max - (x * min);
            //    max = min;
            //    min = r;
            //}
            //while (r > 0);
            //gcd = max;
            //return gcd;
        }
    }
}
