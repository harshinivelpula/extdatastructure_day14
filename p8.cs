using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    public class p8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList10 linkedlist = new LinkedList10();
            linkedlist.AddFirst(56);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(70);

            linkedlist.RemoveFirstNode();
            linkedlist.Display();
            Console.WriteLine("Removed the last node from the linked list");
            LinkedList6 list5 = new LinkedList6();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.RemoveLastNode();
            list5.Display();
            Console.WriteLine("Searching the Nodes");
            LinkedList10 list6 = new LinkedList10();
            list6.AddFirst(40);
            list6.AddFirst(30);
            list6.AddFirst(70);
            list6.RemoveNodeAtParticularPosition(1);
            list6.Display();
            Console.ReadKey();
            Console.WriteLine("create a sorted linked list in acsending order");
            LinkedList1 list7 = new LinkedList1();
            list7.Add(56);
            list7.Add(30);
            list7.Add(40);
            list7.Add(70);
            Console.WriteLine("Before Sorting ");
            list7.Display();
            Console.WriteLine("After Sorting");
            list7.sortList();
            list7.Display();
            Console.ReadLine();
        }
    }
}
