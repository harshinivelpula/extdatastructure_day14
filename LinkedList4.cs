using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class LinkedList4
    {
        internal node3 head; 
        internal void Add(int data)
        {
            node3 node = new node3(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node3 temp = head;
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
            node3 node = new node3(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node3 temp = head;
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
            node3 temp = head;
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
        internal node3 InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new node3(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                node3 temp = this.head;
                while (position-- != 0) 
                {
                    if (position == 1)
                    {
                        node3 node = new node3(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
    }
}
