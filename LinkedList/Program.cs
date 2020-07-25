using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace LinkedList
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

    class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }

        public void Insert(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Node node = new Node(arr[i]);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    node.next = head;
                    head = node;
                }
            }
        }

        public void Insert(int val)
        {
            Node node = new Node(val);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        public void Delete()
        {
            if (head == null)
            {
                Console.WriteLine("Can't delete list is empty");
            }
            else
            {
                Node temp = head;
                head = head.next;
                temp = null;
            }
        }

        public void Traverse()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + ", ");
                temp = temp.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements to enter in linked list");
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            LinkedList list = new LinkedList();
            list.Insert(arr);
            while (true)
            {
                Console.WriteLine("********* Enter choices for operations on Linked List ***********");
                Console.WriteLine("Enter 1 for inserting");
                Console.WriteLine("Enter 2 for traversing");
                Console.WriteLine("Enter 3 for deleting");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Enter a number");
                        int val = Convert.ToInt32(Console.ReadKey());
                        list.Insert(val);
                        break;
                    case 2:
                        list.Traverse();
                        break;
                    case 3:
                        list.Delete();
                        break;
                }
            }
        }
    }
}
