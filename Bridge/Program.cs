using Bridge;
using System;

namespace Bridge_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            //set Implementation and call

            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            //Change implemention and call

            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            Console.ReadKey();

        }
    }


}


