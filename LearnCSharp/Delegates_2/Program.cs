//Multicasting of a Delegate
//- Delegate object có thể được compose (biên soạn) bằng cách sử dụng “+”. “+” sẽ gọi 2 delegate và compose nó.Chỉ những delegate có kiểu tương tự nhau mới được compose. “-” được sử dụng để remove 1 delegate khỏi delegate đã được compose
//- Sử dụng property này của delegate, bạn có thể tạo danh sách invocation (sự cầu khẩn) của method, và sẽ được gọi khi delegate được invoked(được viện dẫn). Đây được gọi là Multicasting delegate

using System;

namespace Delegates_2
{
    delegate int NumberChange(int n);

    internal class Program
    {
        static int num = 10;
        public static int AddNum(int n)
        {
            return num += n;
        }
        public static int MulNum(int n)
        {
            return num *= n;
        }
        public static int getNum() { return num; }

        static void Main(string[] args)
        {
            NumberChange nc;
            NumberChange n1 = new NumberChange(AddNum);
            NumberChange n2 = new NumberChange(MulNum);

            nc = n1 + n2;

            nc(2);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
