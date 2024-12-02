namespace Command_pattern
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // set and execute command

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            // wait for user

            Console.ReadKey();

        }
    }
    
        
}