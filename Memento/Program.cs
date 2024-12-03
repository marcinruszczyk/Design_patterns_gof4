namespace Memento_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            //Store internal state

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            //continue changing originator

            o.State = "off";

            // restore saved state

            o.SetMemento(c.Memento);

            //wait for user
            Console.ReadKey();
        }
    }
}