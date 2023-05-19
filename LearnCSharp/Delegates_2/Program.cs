using System;

namespace Delegates_2
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
            NumberChange nc;
            NumberChange n1 = new NumberChange(AddNum);
            NumberChange n2 = new NumberChange(MulNum);

            nc = n1 + n2;

            nc(2);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
