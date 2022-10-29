using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class p2
    {
        public static void main(string[] args)
        {
                Console.WriteLine("Welcome to Linked List");
                LinkedList4 linkedlist = new LinkedList4();
                linkedlist.Add(56);

                linkedlist.Add(70);
                linkedlist.InsertAtParticularPosition(2, 30);

                LinkedList4 linkedlist4 = new LinkedList4();
                //list.Add(30);
                linkedlist4.Add(56);
                linkedlist4.Add(30);
                linkedlist4.Add(70);
                linkedlist4.Display();
                Console.ReadKey();
                linkedlist.Display();
                Console.ReadLine();
        }
    }
}
