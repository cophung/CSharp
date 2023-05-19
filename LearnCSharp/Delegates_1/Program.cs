using System;

namespace Delegates_1
{
    delegate int NumberChange(int n);

    internal class Program
    {
        static int num = 10;
        public static int AddNum(int n)
        {
            return num += n;
        }
        public static int MulNum(int n)
        {
            return num *= n;
        }
        public static int getNum() { return num; }

        static void Main(string[] args)
        {
            NumberChange n1 = new NumberChange(AddNum);
            NumberChange n2 = new NumberChange(MulNum);

            n1(2);
            Console.WriteLine(num);

            n2(2);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
