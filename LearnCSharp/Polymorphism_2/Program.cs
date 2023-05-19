//Static Polymorphism: Operator Overloading

using System;

namespace Polymorphism_2
{
    class Box
    {
        private double length;
        private double width;
        private double breadth;
        public Box() { }
        public Box(double length, double width, double breadth)
        {
            this.length = length;
            this.width = width;
            this.breadth = breadth;
        }
        public double getVolume()
        {
            return length * width * breadth;
        }
        public static Box operator +(Box left, Box right)
        {
            Box box = new Box();
            box.length = left.length + right.length;
            box.width = left.width + right.width;
            box.breadth = left.breadth + right.breadth;
            return box;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            Box box1 = new Box(1, 2, 3);
            Box box2 = new Box(2, 3, 4);
            box = box1 + box2;
            Console.WriteLine(box1.getVolume());
            Console.WriteLine(box2.getVolume());
            Console.WriteLine(box.getVolume());
            Console.ReadLine();
        }
    }
}
