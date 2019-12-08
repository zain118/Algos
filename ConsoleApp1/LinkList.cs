using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinkList
    {
        public class Node
        {
            internal int data;
            internal Node next;
            internal Node(int data)
            {
                this.data = data;
            }
        }

        Node head;
        public Node Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
            return head;
        }
        public string AddAtPosition(int data, int position)
        {
            Node node = new Node(data);
            if (head != null)
            {
                int index = 1;
                Node current = head;
                if (position == 0)
                {
                    Node temp = head;
                    head = node;
                    head.next = temp;
                    return "Added";
                }
                while (current != null)
                {
                    if (position != index)
                    {
                        current = current.next;
                        index++;
                    }
                    else
                    {
                        Node temp = current.next;
                        current.next = node;
                        node.next = temp;
                        return "Added";
                    }
                }
            }
            return "No Pos";
        }
        public string Delete(int data)
        {
            if (head == null)
            {
                return "Not Found - Empty List";
            }
            else
            {
                Node current = head.next;
                Node prev = head;
                if (head.data == data)
                {
                    head = head.next;
                    return "Deleted";
                }
                else
                {
                    while (current != null)
                    {
                        if (data == current.data)
                        {
                            prev.next = current.next;
                            return "Deleted";
                        }
                        else
                        {
                            prev = current;
                            current = current.next;
                        }
                    }
                }
                return "Not Found";
            }
        }
        public int DeleteAtPosition(int position)
        {
            int ret;
            if (head == null)
            {
                return 99999;
            }
            else
            {
                Node current = head.next;
                Node prev = head;
                if (position == 0)
                {
                    ret = head.data;
                    head = head.next;
                    return ret;
                }
                else
                {
                    int index = 1;
                    while (current != null)
                    {
                        if (position == index)
                        {
                            ret = current.data;
                            prev.next = current.next;
                            return ret;
                        }
                        else
                        {
                            prev = current;
                            current = current.next;
                            index++;
                        }
                    }
                }
                return 99999;
            }
        }
        public void PrintAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void ReverseList()
        {
            if (head != null)
            {
                Node current = head;
                Node prev = null;
                Node newNext = head.next;

                while (current != null)
                {
                    newNext = current.next;
                    current.next = prev;
                    prev = current;
                    current = newNext;

                }
                head = prev;
                PrintAll();
            }
        }
        public void ReverseListRecursive(Node n)
        {
            if (n!=null && n.next != null)
            {
                
                ReverseListRecursive(n.next);
                Node t = n.next;
                t.next = n;
                n.next = null;
            }
            else
            {
                head = n;
                return;
            }
        }
        public void PrintRecursive(Node current)
        {
            if (current == null)
            {
                return;
            }
            Console.WriteLine(current.data);
            PrintRecursive(current.next);
        }
        public void PrintReverseRecursive(Node current)
        {
            if (current == null)
            {
                return;
            }
            PrintReverseRecursive(current.next);
            Console.WriteLine(current.data);

        }
        public void IsCircular()
        {
            Node current = head;

        }
        public Node AddToCircular(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                node.next = current;
                head = node;
            }
            return head;
        }
        public string GetElements(int take, int skip)
        {
            Node current = head;
            string elements = "";
            if (head != null)
            {
                while (current != null)
                {
                    int takeIndex = 0;
                    int skipIndex = 0;

                    while (current != null && takeIndex != take)
                    {
                        elements += " " + current.data;
                        current = current.next;
                        takeIndex++;
                    }

                    while (current != null && skipIndex != skip)
                    {
                        current = current.next;
                        skipIndex++;
                    }
                }
            }
            return elements;
        }
    }
}
