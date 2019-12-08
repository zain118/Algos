using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stack
    {
        protected class Node
        {
            internal int data;
            internal Node next;
            internal Node(int data)
            {
                this.data = data;
            }
        }
        protected Node top;
        public Boolean isEmpty()
        {
            return top == null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            node.next = top;
            top = node;
        }
        public int Pop()
        {
            int data = top.data;
            top = top.next;
            return data;
        }
        public int Peek()
        {
            return top.data;
        }
    }
}
