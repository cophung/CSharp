////Thread được định nghĩa như một luồng thực thi của chương trình. Mỗi thread là độc nhất. Nếu chương trình của bạn liên quan tới độ phức tạp và thời gian xử lý lâu, thì đa luồng là giải pháp, mỗi luồng thực thi một công việc cụ thể

//Thread Life Cycle
//Vòng đời của Thread bắt đầu khi một object của System.Threading.Thread class được tạo và kết thúc khi thread đó bị chấm dứt hoặc thực thi xong

//Một vài state trong vòng đời của Thread
//The Unstarted State: thread được tạo nhưng method Start không được
//The Ready State: thread sẳn sàng để chạy và chờ CPU cycle
//The Not Runnable State: thread sẽ không thực thi khi
//	Sleep method được gọi
//	Wait method được gọi
//	Bị block bởi I/O operation
//The Dead State: thread thực thi hoàn thành hoặc bị hủy bỏ

//The Main Thread
//Class System.Threading.Thread được dùng để work với thread. Nó được dùng để tạo và truy cập vào từng thread cụ thể trong nhiều thread. Thread đầu tiên được thực thi được gọi là main thread
//Khi chương trình bắt đầu thực thi, main thread sẽ tự động được khởi tạo. Thread được tạo sử dụng Thread class được gọi thread con trong main thread. Bạn có thể truy cập một thread bằng cách sử dụng thuộc tính CurrentThread của Thread class

using System;
using System.Threading;

namespace Multithreading_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "main";

            Console.WriteLine(thread.Name);
            Console.ReadLine();
        }
    }
}
