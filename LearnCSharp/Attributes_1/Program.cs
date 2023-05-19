//- Một attribute là một tag khai báo được sử dụng để truyền đạt thông tin đến runtime về hành vi của element như class, method, structure, enumerator, assemblies trong chương trình
//- Bạn có thể thêm thông tin khai báo đến chương trình bằng cách sử dụng attribute. Một tag khai báo được mô tả bằng dấu ngoặc vuông được đặt phía trên element sử dụng nó
//- Được sử dụng để thêm metadata, chẳng hạn như compiler instruction và những thông tin khác như comments, description, method, class trong chương trình.
//- .NET Framework cung cấp 2 loại attribute: pre - defined attribute và custom built attribute


//Pre-defined attribute: Conditional
//Syntax: [Conditionnal(ConditionalSymbol)]

#define TEST
using System;
using System.Diagnostics;

namespace Attributes_1
{
    public class MyClass
    {
        [Conditional("TEST")]
        public void Test_1()
        {
            Console.WriteLine("TEST");
        }

        [Conditional("HELLO")]
        public void Test_2()
        {
            Console.WriteLine("HELLO");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Test_1();
            myClass.Test_2();
            Console.ReadLine();
        }
    }
}
