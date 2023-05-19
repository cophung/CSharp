//Generic Delegates

using System;

delegate T NumberChange<T>(T value);

namespace Generics_3
{

    internal class Program
    {
        static int number = 0;
        public static int AddNum(int num)
        {
            return number += num;
        }
        public static int MulNum(int num)
        {
            return number *= num;
        }
        public static int GetNum()
        {
            return number;
        }
        static void Main(string[] args)
        {
            NumberChange<int> nc1 = new NumberChange<int>(AddNum);
            NumberChange<int> nc2 = new NumberChange<int>(MulNum);

            nc1(2);
            Console.WriteLine(GetNum());

            nc2(3);
            Console.WriteLine(GetNum());

            Console.ReadLine();
        }
    }
}
