using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSA.Core.Algorithms.Arrays
{
    public static class FindTheDuplicates
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 2,3,4,4,4};

            List<int> ls = arr.ToList();

            List<int> res = ls.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).ToList();
            Console.WriteLine("uniques are: " + string.Join(" ", res));

            List<int> res2 = ls.GroupBy(x => x).Where(g => g.Count() > 1).Select(x => x.Key).ToList();
            Console.WriteLine("duplicates are: " + string.Join(" ", res2));

            // boxing and unboxing

            int a = 10;
            object o = 11; // boxing
            int b = (int)o; // unboxing

            Dictionary<int, int> d = new Dictionary<int, int>();

            foreach (int c in arr)
            {
                if (d.ContainsKey(c))
                {
                    d[c]++;
                } else
                {
                    d[c] = 1;
                }
            }

            foreach(var item in d)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
