using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = " 200-100 + 20 ";
            string b = " 20+23+3 ";
            string c = "(10+(30+50+30)-30)+(60+80)";
            string d= "(10+(4+5+3)-3)+(6+80)";
            SimpleCalculator calculator=new SimpleCalculator();
            //Console.WriteLine("result should be 120,result={0}",calculator.Calculate(a));
            //Console.WriteLine("result should be 27,result={0}",calculator.Calculate(b));
            Console.WriteLine("result should be 24,result={0}",calculator.Calculate(c));
            //Console.WriteLine("result should be 105,result={0}",calculator.Calculate(d));

            Console.ReadKey();
        }
    }
}
