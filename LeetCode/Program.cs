using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] nums1 = {4, 1, 2};
           int[] nums2 = { 1, 2, 3, 4 };
            NextGreaterElementI next=new NextGreaterElementI();

            Console.WriteLine("should be [-1,3,-1],{0}", next.NextGreaterElement(nums1,nums2));

            Console.ReadKey();
        }
    }
}
