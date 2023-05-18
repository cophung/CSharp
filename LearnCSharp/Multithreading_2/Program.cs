using System;
using System.Threading;

namespace Multithreading_2
{
    internal class Program
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Child thread start");

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i);
                }

                Console.WriteLine("Child thread complete");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("ThreadAbortException");
            }
            finally
            {
                Console.WriteLine("could not catch thread exception");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(CallToChildThread);
            Console.WriteLine("Main: creating the child thread");
            Thread thread = new Thread(threadStart);
            thread.Start();
            Thread.Sleep(2000);
            Console.WriteLine("Main: abort the child thread");
            thread.Abort();
            Console.ReadLine();
        }
    }
}
