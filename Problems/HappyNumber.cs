using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeDotNet.Problems
{
    internal class HappyNumber
    {
        public static bool IsHappyNumber(int n)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            while (true)
            {
                List<int> digits = new List<int>();
                while (n >= 10)
                {
                    digits.Add(n % 10);
                    n /= 10;
                }
                digits.Add(n);
                int total = 0;
                foreach (int digit in digits)
                {
                    total += (int) Math.Pow(digit, 2);
                }
                n = total;
                if (seen.ContainsKey(n))
                {
                    break;
                }
                else if (n == 1)
                {
                    return true;
                }
                seen[n] = 1;
            }
            return false;
        }
    }
}
