using System;

namespace Events_1
{
    internal class Program
    {
        public delegate string MyDel(string str);
        event MyDel MyEvent;

        public string WelcomeUser(string str)
        {
            return $"Welcome {str}";
        }

        public Program()
        {
            this.MyEvent += new MyDel(WelcomeUser);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            string str = program.MyEvent("Jame");
            Console.WriteLine(str);
            string str2 = program.MyEvent("Peter");
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
