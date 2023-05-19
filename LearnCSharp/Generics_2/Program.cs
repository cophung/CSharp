//Generic Methods

using System;

namespace Generics_2
{
    internal class Program
    {
        static void Swap<T>(ref T item1, ref T item2)
        {
            T temp;
            temp = item1;
            item1 = item2;
            item2 = temp;
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a: {a}, b: {b}");
            Console.ReadLine();
        }
    }
}
