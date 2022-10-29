using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    public class p3
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");

            LinkedList5 linkedlist = new LinkedList5();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.RemoveFirstNode();
            linkedlist.Display();
            Console.ReadLine();
        }
    }
}
