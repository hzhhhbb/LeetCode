using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           StringCompare queue=new StringCompare();
           string i = "a#c";
           string t = "b";

           Console.WriteLine("should true :{0}",queue.BackspaceCompare(i,t));

           Console.ReadKey();
        }
    }
}
