//Cho phép pass một code block như một tham số delegate. Là một method không có tên chỉ có body.Bạn không cần phải chỉ định loại trả về, anonymous methods tự xác định loại trả về

//Writing an Anonymous Method
//- Anonymous methods được khai báo dựa trên khai báo của delegate
//- Delegate có thể gọi được cả anonymous methods cũng như tên method cùng một cách bằng cách pass param method vào delegate object

using System;

delegate void NumberChanger(int n);

namespace AnonymousMethods_1
{
    internal class Program
    {
        static int num = 2;
        public static void AddNum(int n)
        {
            num += n;
            Console.WriteLine($"AddNum: {num}");
        }
        public static void MulNum(int n)
        {
            num *= n;
            Console.WriteLine($"MulNum: {num}");
        }
        static void Main(string[] args)
        {
            //Create delegate instances using Anonymous Method
            NumberChanger nc = delegate (int n)
            {
                Console.WriteLine($"This is Anonymous Method");
                Console.WriteLine($"n: {n}");
            };

            //Call the delegate using the Anonymous Method
            nc(3);

            //Instantiating the delegate using the named methods
            nc = new NumberChanger(AddNum);
            //Calling the delegate using the named methods
            nc(4);

            //Instantiating the delegate using the named methods
            nc = new NumberChanger(MulNum);
            //Calling the delegate using the named methods
            nc(5);

            Console.ReadLine();
        }
    }
}
