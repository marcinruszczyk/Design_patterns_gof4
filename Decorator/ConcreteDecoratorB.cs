using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_pattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddBehavior()
        {
        }

    }
}
