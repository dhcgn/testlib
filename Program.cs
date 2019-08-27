using System;
using System.Threading;

namespace TestLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and bye in 5s");
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
