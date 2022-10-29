using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class p1
    {
        static void Display()
        {
            Console.WriteLine("Welcome to Linked List");
            LinkedList3 linkedlist = new LinkedList3();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            
            LinkedList3 linkedlist0 = new LinkedList3();
            
            linkedlist0.Add(56);
            linkedlist0.Add(30);
            linkedlist0.Add(70);
            linkedlist0.Display();
            Console.ReadKey();
            linkedlist.Display();
            Console.ReadLine();
        }
    }
}
