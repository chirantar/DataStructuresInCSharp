using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }

    class CircularLinkedList
    {
        Node head;
        public CircularLinkedList()
        {
            head = null;
        }

        public void InsertAtHead(int val)
        {
            Node temp = new Node(val);
            if (head == null)
            {
                head = temp;
                head.next = head;
            }
            else
            {
                temp.next = head.next;
                head.next = temp;
            }
        }

        public int DeleteLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Empty list");
                return Int32.MinValue;
            }
            else if (head.next == head)
            {
                int data = head.data;
                head = null;
                return data;
            }
            else
            {
                Node p, q;
                p = q = head;
                do
                {
                    q = p;
                    p = p.next;
                } while (p.next != head);
                int data = p.data;
                q.next = p.next;
                p = null;
                return data;
            }
        }

        public void Traverse()
        {
            Console.WriteLine("Traversing data");
            Node p = head;
            if (head == null)
                return;
            do
            {
                Console.Write($"{p.data},");
                p = p.next;
            } while (p != head);
            Console.WriteLine("\b");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList cll = new CircularLinkedList();
            int[] arr = {1, 2, 3, 4, 5};
            foreach (int i in arr)
            {
                cll.InsertAtHead(i);
            }

            cll.Traverse();
            cll.DeleteLastNode();
            cll.Traverse();
            cll.DeleteLastNode();
            cll.Traverse();


            Console.Read();
        }
    }
}
