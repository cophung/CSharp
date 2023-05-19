//Dynamic Polymorphism: Abstract class

using System;

namespace Polymorphism_3
{
    public abstract class Shape
    {
        public abstract int area();
    }
    public class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public override int area()
        {
            return length * width;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 2);
            int area = rectangle.area();
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
