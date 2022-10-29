using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    public class p
    {
        public static void program()
            {
                Console.WriteLine("Welcome to Linked List");

                LinkedList2 linkedlist = new LinkedList2();
                linkedlist.Add(70);
                linkedlist.Add(30);
                linkedlist.Add(56);
                linkedlist.Display();

                Console.ReadLine();
            }
    }
}
