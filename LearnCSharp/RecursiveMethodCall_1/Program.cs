// Đệ quy

using System;

namespace RecursiveMethodCall_1
{
    internal class Program
    {
        public int factorial(int num)
        {
            int intResult;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                intResult = factorial(num - 1) * num;
            }
            return intResult;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.factorial(3));
            Console.ReadLine();
        }
    }
}
