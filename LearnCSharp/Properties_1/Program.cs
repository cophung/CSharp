//Properties
//- Đặt tên member của class, structure và interface
//-Member varibale hoặc method trong class được gọi là fields
//- Là sự mở rộng của field và được truy cập sử dụng syntax tương tự. Ta sử dụng accessors, thông qua nó ta có thể đọc, viết và chỉnh sửa
//- Properties không đặt tên cho vị trí lưu trữ. Thay vào đó, ta sử dụng accessors để đọc, viết và chỉnh sửa giá trị của chúng

//Accessors
//- Chứa statement có thể thực thi giúp ta có thể đọc hoặc tính toán (get) hoặc viết(set) property.Accessor khai báo có thể chứa get, set hoặc cả hai

using System;

namespace Properties_1
{
    class Student
    {
        private string code = "N.A";

        //Accessors: Declare a Code property of type string
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public override string ToString()
        {
            return $"Code = {code}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Code = "007";
            Console.WriteLine(student.ToString());
            Console.ReadLine();
        }
    }
}
