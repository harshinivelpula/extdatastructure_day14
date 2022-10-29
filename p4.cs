using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    public class p4
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to Linked List");

            LinkedList6 linkedlist = new LinkedList6();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.RemoveLastNode();
            linkedlist.Display();
            Console.ReadLine();
        }

    }
}
