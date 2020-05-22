using System;

namespace aopLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Adding 1+1, result is {Add(1,1)}");
        }

        [LoggingAspect]
        static int Add(int a, int b){
            return a+b;
        }
    }
}
