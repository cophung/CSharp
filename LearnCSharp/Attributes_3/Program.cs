//Creating Custom Attributes
//- Được sử dụng để lưu trữ thông tin khai báo và được lấy lúc run time.
//- Thông tin này có thể liên quan tới bất kỳ element nào tùy thuộc vào tiêu chí thiết kế và nhu cầu ứng dụng

//Ứng dụng của Reflection
//- Cho phép xem thông tin attribute lúc runtime
//- Cho phép kiểm tra nhiều kiểu trong assembly và khởi tạo những kiểu này
//- Cho phép late binding đến method và property
//- Cho phép tạo type mới lúc runtime và thực thi task sử dụng những type này

using System;
using System.Reflection;

namespace Attributes_3
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)] // Step 1
    public class DebugInfo : Attribute // Step 2
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DebugInfo(int bugNo, string developer, string lastReview)
        {
            this.bugNo = bugNo;
            this.developer = developer;
            this.lastReview = lastReview;
        }

        public int BugNo { get { return bugNo; } }
        public string Developer { get { return developer; } }
        public string LastReview { get { return lastReview; } }
        public string Message { get { return message; } set { message = value; } }
    }

    [DebugInfo(1, "First", "19/05/2023", Message = "Hello First")] // Step 3

    [DebugInfo(2, "Second", "20/05/2023", Message = "Hello Second")] // Step 3
    class Shape
    {
        protected int length = 0;
        protected int width = 0;
        public Shape(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        [DebugInfo(3, "Third", "21/05/2023")] // Step 3
        public virtual int area()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int length, int width) : base(length, width) { }
        [DebugInfo(4, "Four", "22/05/2023", Message = "Hello four")] // Step 3
        public override int area()
        {
            return width * length;
        }
        public void Display()
        {
            Console.WriteLine($"Length: {length}, Width: {width}, Area: {area()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 2);
            rectangle.Display();

            Type type = rectangle.GetType();

            #region Step 4: Ứng dụng của Reflection

            Console.WriteLine("Class: GetCustomAttributes(false)");
            foreach (Attribute attribute in type.GetCustomAttributes(false)) // không lấy được attribute class
            {
                DebugInfo debugInfo = attribute as DebugInfo;
                Console.WriteLine($"BugNo: {debugInfo.BugNo}, Developer: {debugInfo.Developer}, LastReview: {debugInfo.LastReview}, Message: {debugInfo.Message}");
            }

            Console.WriteLine("Class: GetCustomAttributes(true)");
            foreach (Attribute attribute in type.GetCustomAttributes(true)) // lấy được attribute class
            {
                DebugInfo debugInfo = attribute as DebugInfo;
                Console.WriteLine($"BugNo: {debugInfo.BugNo}, Developer: {debugInfo.Developer}, LastReview: {debugInfo.LastReview}, Message: {debugInfo.Message}");
            }

            Console.WriteLine("Method: GetCustomAttributes(false)");
            foreach (MemberInfo memberInfo in type.GetMethods())
            {
                foreach (Attribute attribute in memberInfo.GetCustomAttributes(false)) // chỉ lấy được method của derived class
                {
                    DebugInfo debugInfo = attribute as DebugInfo;
                    if (debugInfo != null)
                    {
                        Console.WriteLine($"Method: {memberInfo.Name}, BugNo: {debugInfo.BugNo}, Developer: {debugInfo.Developer}, LastReview: {debugInfo.LastReview}, Message: {debugInfo.Message}");
                    }
                }
            }

            Console.WriteLine("Method: GetCustomAttributes(true)");
            foreach (MemberInfo memberInfo in type.GetMethods())
            {
                foreach (Attribute attribute in memberInfo.GetCustomAttributes(true)) // lấy được method của base class & derived class
                {
                    DebugInfo debugInfo = attribute as DebugInfo;
                    if (debugInfo != null)
                    {
                        Console.WriteLine($"Method: {memberInfo.Name}, BugNo: {debugInfo.BugNo}, Developer: {debugInfo.Developer}, LastReview: {debugInfo.LastReview}, Message: {debugInfo.Message}");
                    }
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
