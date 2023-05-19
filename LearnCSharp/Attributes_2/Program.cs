// Pre-defined attribute: Obsolete
//- message mô tả lý do tại sao lại sử dụng Obsolete và sử dụng thay thể cái gì
//- iserror true ⇒ error, false ⇒ warning
//- Attribute này đánh dấu element có nên sử dụng. Nó cho phép bạn thông báo đến compiler bỏ qua element cụ thể. Ví dụ, khi một method mới được sử dụng trong class và nếu bạn vẫn muốn giữ lại method cũ trong class, bạn có thể đánh dấu method này bằng obsolete, bằng cách này sẽ chỉ hiển thị message của method mới thay vì method cũ

//Syntax_1: [Obsolete(message)]
//Syntax_2: [Obsolete(message, iserror)]

using System;

namespace Attributes_2
{
    internal class Program
    {
        [Obsolete("do not use old method, use new method instead")]
        public void oldMethod()
        {
            Console.WriteLine("This is old method");
        }

        [Obsolete("do not use old method 1, use new method instead", true)]
        public void oldMethod_1()
        {
            Console.WriteLine("This is old method 1");
        }

        public void newMethod()
        {
            Console.WriteLine("This is new method");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.oldMethod(); // display warning list
            //program.oldMethod_1(); // display error list
            program.newMethod();
            Console.ReadLine();
        }
    }
}
