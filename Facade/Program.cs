namespace Facade_pattern
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // wait for user

            Console.ReadKey();  
        }
    }


}

