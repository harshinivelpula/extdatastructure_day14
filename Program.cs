namespace datastructureext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");

            LinkedList1 linkedlist = new LinkedList1();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.Display();

            Console.ReadLine();
        }
    }
}