//Cho phép viết class hoặc method có thể work với bất cứ data type nào

//Đặc trưng của generics
//- Tái sử dụng, an toàn và hiệu quả
//- Bạn có thể tạo generic collection class. Thư viện class .NET Framework có chứa một vài generic collection class trong System.Collections.Generic namespace. Bạn có thể sử dụng những generic collection class này thay vì collection class trong System.Collections namespace
//- Bạn có thể tạo những generic interface, class, method, event, delegate của bạn
//- Bạn có thể tạo generic class bị ràng buộc truy cập tới method trên data type cụ thể
//- Bạn có thể lấy thông tin về các loại đang sử dụng trong một loại data generic lúc runtime bằng reflection

//Generic Class

using System;

namespace Generics_1
{
    class MyGenericClass<T>
    {
        private int intLength = 0;
        private T[] array;
        public MyGenericClass(int intSize)
        {
            intLength = intSize;
            array = new T[intSize];
        }
        public int Length { get { return intLength; } }
        public T GetItem(int intIndex)
        {
            return array[intIndex];
        }
        public void SetItem(int index, T item)
        {
            array[index] = item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("myGenericClassInt");
            MyGenericClass<int> myGenericClassInt = new MyGenericClass<int>(3);
            myGenericClassInt.SetItem(0, 100);
            myGenericClassInt.SetItem(1, 200);
            myGenericClassInt.SetItem(2, 300);
            for (int i = 0; i < myGenericClassInt.Length; i++)
            {
                Console.WriteLine(myGenericClassInt.GetItem(i));
            }

            Console.WriteLine("myGenericClassString");
            MyGenericClass<string> myGenericClassString = new MyGenericClass<string>(3);
            myGenericClassString.SetItem(0, "First");
            myGenericClassString.SetItem(1, "Second");
            myGenericClassString.SetItem(2, "Third");
            for (int i = 0; i < myGenericClassInt.Length; i++)
            {
                Console.WriteLine(myGenericClassInt.GetItem(i));
            }

            Console.ReadLine();
        }
    }
}
