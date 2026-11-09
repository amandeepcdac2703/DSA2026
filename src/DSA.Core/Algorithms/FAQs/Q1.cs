using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Core.Algorithms.FAQs
{
    public static class Q1
    {
        public static void Run()
        {
            string str = "My Name is Aman";

            // Reverse the word

            Stack<string> stack = new Stack<string>();

            List<string> ls = str.Split(' ').ToList<string>();

            int s = 0;
            int e = ls.Count - 1;

            while (s <= e )
            {
                (ls[s], ls[e]) = (ls[e], ls[s]);
                s++;
                e--;
            }

            
            string str2 = string.Join(" ", ls);
            Console.WriteLine(str2);


            List<string> lss = str.Split(' ').ToList<string>();
            int count = 0;
            string res = "";
            foreach(var item in lss)
            {
                List<char> chls = item.ToList();
                if(count < chls.Count)
                {
                    chls.RemoveAt(count);
                }
                count++;
                string st = new string(chls.ToArray());
                res += st;
                res += " ";


            }

            //string str3 = string.Join(" ", ls2);
            Console.WriteLine("delted chars");
            Console.WriteLine(res);
        }
    }
}
