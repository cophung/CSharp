//Interface

using System;

namespace Inheritance_2
{
    class Shape
    {
        protected int length;
        protected int width;
        public void SetLength(int length) { this.length = length; }
        public void SetWidth(int width) { this.width = width; }
    }
    interface PainCost
    {
        int GetCost(int area);
    }
    class Rectangle : Shape, PainCost
    {
        public int GetArea()
        {
            return length * width;
        }
        public int GetCost(int area)
        {
            return area * 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(2);
            rectangle.SetWidth(3);
            int area = rectangle.GetArea();
            int cost = rectangle.GetCost(area);
            Console.WriteLine($"area: {area}, cost: {cost}");
            Console.ReadLine();
        }
    }
}
