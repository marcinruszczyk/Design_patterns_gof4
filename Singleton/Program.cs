using System;

namespace Singleton_pattern
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Singleton s1 = new Singleton();
            Singleton s2 = new Singleton(); 

            //test for the same instance

            if (s1 == s2) 
            {
                Console.WriteLine("Objects are the same");
            }
             
            Console.ReadKey();
        }
    }

}