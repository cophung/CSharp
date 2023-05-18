using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_2
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
    }
    class Student : Person
    {
        private string code = "n.a";
        private string name = "n.a";
        //Declare Code property of type string
        public string Code { get { return code; } set { code = value; } }
        //Declare Name property of type string
        public override string Name { get { return name; } set { name = value; } }
        public override string ToString()
        {
            return $"Code {code}, Name {Name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Code = "007";
            student.Name = "Jame";
            Console.WriteLine(student.ToString());
            Console.ReadLine();
        }
    }
}
