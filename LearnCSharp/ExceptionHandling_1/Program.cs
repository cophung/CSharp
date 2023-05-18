using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_1
{
    class TempIsZeroException : Exception
    {
        public TempIsZeroException(string strMessage) : base(strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TempIsZeroException tempIsZeroException = new TempIsZeroException("Hello");
                int zero = 0;
                int result = 1 / zero;
                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new TempIsZeroException(e.Message);
            }
        }
    }
}
