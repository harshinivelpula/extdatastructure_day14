using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class LinkedList2
    {
        internal node1 head;
        internal void Add(int data)
        {
            node1 node = new node1(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node1 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.Write("\n {0} inserted into linked list", node.data);
        }
        public void AddinreverseOrder(int data)
        {
            node1 newNode = new node1(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                node1 temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.Write("\n {0} inserted into linked list", newNode.data);
        }
        internal void Display()
        {
            Console.Write("\n Data of linked list : ");
            node1 temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
