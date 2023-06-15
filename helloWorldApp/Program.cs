using System;

namespace helloWorldApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(returnMessage());
            Console.WriteLine("Test 2");
            Console.WriteLine("Test message");
        }

        public static string returnMessage()
        {
            return "Hello World!";
        }
    }
}
