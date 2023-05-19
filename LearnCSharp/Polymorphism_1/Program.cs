//Tính đa hình (có nhiều form)
//Trong mô hình OOP, polymorphism được hiểu là một interface nhiều function
//Có thể là static hoặc dynamic.Trong static, response tới function thì được xác định lúc compile time. Trong dynamic, response xác đinh lúc run time

//Static Polymorphism
//Cơ chế liên kết một function với một object lúc compile được gọi là early binding (ràng buộc sớm) hay được gọi là static binding

//Static Polymorphism: Function Overloading

using System;

namespace Polymorphism_1
{
    internal class Program
    {
        public void print(string message)
        {
            Console.WriteLine(message);
        }
        public void print(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.print("hello");
            program.print(1);
            Console.ReadLine();
        }
    }
}
