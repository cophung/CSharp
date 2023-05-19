//Inheritance
//1. Base class, Derived class
//2. Multiple Inheritance
//2.1. Interface


// Base class, Derived class
using System;

namespace Inheritance_1
{
    class Rectangle
    {
        protected int length;
        protected int width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine($"Rectangle: length: {length}, width: {width}, area: {GetArea()}");
        }
    }
    class TableTop : Rectangle
    {
        public TableTop(int length, int width) : base(length, width) { }
        public int GetCost(int intCost)
        {
            return GetArea() * intCost;
        }
        public new void Display()
        {
            Console.WriteLine($"TableTop: length: {length}, width: {width}, area: {GetArea()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TableTop tableTop = new TableTop(2, 3);
            tableTop.Display();
            Console.WriteLine(tableTop.GetCost(2));
            Console.ReadLine();
        }
    }
}
