using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class p7
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to Linked List");

            LinkedList9 linkedlist = new LinkedList9();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(40);
            linkedlist.Add(70);
            linkedlist.Display();
            int position = linkedlist.Search(40);
            linkedlist.DeleteNodeAtParticularPosition(position);
            Console.ReadLine();
        }
    }
}
