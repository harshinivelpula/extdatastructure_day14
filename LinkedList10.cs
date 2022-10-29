using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructureext
{
    internal class LinkedList10
    {
        internal Node head; 
        public static void Display()
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
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
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Append linked list", node.data);
        }
        public static void Display()
        {
            Node temp = this.head;
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
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0) 
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
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
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemovaLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
        internal void RemoveNodeAtParticularPosition(int position)
        {

            if (head == null)
                return;

            Node temp = head;

            if (position == 0)
            {

                head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)
                temp = temp.next;

            if (temp == null || temp.next == null)
                return;

            Node next = temp.next.next;

            temp.next = next;
        }
        internal void sortList()
        {
            Node current = head, index = null;
            int temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;

                    while (index != null)
                    {
                        if (current.data > index.data)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
    }
}
