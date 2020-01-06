using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = {"5", "2", "C", "D", "+"};
            string[] b = {"5", "-2", "4", "C", "D", "9", "+", "+" };
            BaseballGame game=new BaseballGame();

            Console.WriteLine("should be 30,{0}",game.CalPoints(a));
            Console.WriteLine("should be 27,{0}",game.CalPoints(b));
    }
    }
}
