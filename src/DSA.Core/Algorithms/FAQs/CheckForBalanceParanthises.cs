
using System;
using System.Collections.Generic;

namespace DSA.Core.Algorithms.FAQs
{
    public static class CheckForBalanceParanthises
    {
        public static void Run()
        {
            string str = "({[]})";

            Stack<char> stack = new Stack<char>();

            bool isBalanced = true;

            foreach (char c in str)
            {
                // Opening brackets
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // Closing brackets
                else if (c == ')' || c == '}' || c == ']')
                {
                    // No opening bracket available
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char popped = stack.Pop();

                    if ((c == ')' && popped != '(') ||
                        (c == ']' && popped != '[') ||
                        (c == '}' && popped != '{'))
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            // Remaining opening brackets mean unbalanced
            if (stack.Count != 0)
            {
                isBalanced = false;
            }

            Console.WriteLine(
                isBalanced ? "Balanced" : "Not Balanced");
        }
    }
}
