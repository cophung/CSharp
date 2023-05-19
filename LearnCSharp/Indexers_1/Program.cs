//Cho phép 1 object lập index như array
//This project is Overloaded Indexers


using System;

namespace Indexers_1
{
    internal class Program
    {
        public static int size = 10;
        private string[] nameList = new string[size];
        public Program()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N.A";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp = "";
                if (index >= 0 && index < size)
                {
                    tmp = nameList[index];
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    nameList[index] = value;
                }
            }
        }
        public int this[string strName]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (nameList[index] == strName)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program[0] = "mon";
            program[1] = "tus";
            program[2] = "wed";

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i}: {program[i]}");
            }

            Console.WriteLine($"index of tus is {program["tus"]}");
            Console.ReadLine();
        }
    }
}
