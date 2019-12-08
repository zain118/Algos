using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DoublyLinkList
    {
        public class Node
        {
            internal int data;
            internal Node next;
            internal Node prev;
            internal Node(int data)
            {
                this.data = data;
            }
        }
        Node head;
        public void Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = n;
                n.prev = current;
            }
        }
        public void Delete()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                Node prev = current.prev;
                prev.next = null;
            }
        }
        public void DeleteAtPos(int pos)
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node current = head;
                int index = 0;
                if (pos == 1)
                {
                    head = head.next;
                }
                else
                {
                    while (current != null)
                    {
                        if (pos == index)
                        {
                            Node p = current.prev;
                            if (current.next != null)
                            {
                                Node q = current.next;
                                p.next = q;
                                q.prev = p;
                            }
                            else
                            {
                                p.next = null;
                            }
                            break;
                        }
                        else
                        {
                            current = current.next;
                            index++;
                        }
                    }
                }
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
    }
}
