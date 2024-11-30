namespace Proxy_pattern
{

    public class Program
    {
        public static void Main(string[] args) 
        {
            //create proxy and request a service

            Proxy proxy = new Proxy();
            proxy.Request();

            //wait for user

            Console.ReadKey();
        }
    }
}