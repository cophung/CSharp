//- Một biến loại tham chiếu giữ tham chiếu đến một phương thức
//- Được sử dụng để thực hiện các sự kiện và các phương thức gọi lại
//- Nói cách khác, ta có thể gọi method có thể được tham chiếu bởi một delegate bằng cách sử dụng delegate object
//- Khi một delegate được khai báo, một delegate object phải được tạo với keyword new và được liên kết với một method cụ thể. Khi tạo một delegate, tham số được pass vào biểu thức mới tương tự như một call, nhưng không có tham số đến method

using System;

namespace Delegates_1
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
            NumberChange n1 = new NumberChange(AddNum);
            NumberChange n2 = new NumberChange(MulNum);

            n1(2);
            Console.WriteLine(num);

            n2(2);
            Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
