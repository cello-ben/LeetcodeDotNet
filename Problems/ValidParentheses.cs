using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeDotNet.Problems
{
    internal class ValidParentheses
    {
        public static bool AreValidParentheses(string s)
        {
            List<char> stack = new List<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Add(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack[stack.Count - 1];
                    if (c == ')' && top == '(' || c == ']' && top == '[' || c == '}' && top == '{')
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
