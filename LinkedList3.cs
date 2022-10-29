using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class LinkedList3
    {
        internal node2 head; 
        internal void Add(int data)
        {
            node2 node = new node2(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node2 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);

        }
        internal void AddFirst(int data)
        {
            node2 node = new node2(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node2 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Append linked list", node.data);
        }
        internal void Display()
        {
            node2 temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; 
            }
            Console.WriteLine("\n");
        }
    }
}
