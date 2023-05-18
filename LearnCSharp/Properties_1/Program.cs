using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
