using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeDotNet.Problems
{
    internal class NumberOf1Bits
    {
        public static int HammingWeight(int n)
        {
            int bits = 0;
            while (n > 0)
            {
                bits += n % 2;
                n /= 2;
            }
            return bits;
        }
    }
}
