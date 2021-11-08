using System;

namespace helloWorldApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(returnMessage());
        }

        public static string returnMessage()
        {
            return "Hello World!";
        }
    }
}
