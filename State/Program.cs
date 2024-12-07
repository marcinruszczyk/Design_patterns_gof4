
namespace State_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey();



        }
    }
}