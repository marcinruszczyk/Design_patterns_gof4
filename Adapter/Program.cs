using System;

namespace Adapter_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create adapter and palce a request
            Target target = new Adapter();
            target.Request();

            //wait for user
            Console.ReadKey();


        }
    }
}