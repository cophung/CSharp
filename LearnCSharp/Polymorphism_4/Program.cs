// Dynamic Polymorphism: Virtual function

using System;

namespace Polymorphism_4
{
    class Shape
    {
        protected int width, height;
        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public virtual int area()
        {
            Console.WriteLine("area class shape");
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height) { }
        public override int area()
        {
            Console.WriteLine("area class rectangle");
            return width * height;
        }
    }
    class Caller
    {
        public void callArea(Shape shape)
        {
            Console.WriteLine("call area");
            Console.WriteLine(shape.area());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Caller caller = new Caller();
            Rectangle rectangle = new Rectangle(1, 2);
            caller.callArea(rectangle);
            Console.ReadLine();
        }
    }
}
