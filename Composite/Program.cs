namespace Composite_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            //Add and remove a leaf

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            //Recurseively display tree

            root.Display(1);

            //wait for user
            Console.ReadKey();



        }
    }
}

