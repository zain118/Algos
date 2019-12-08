using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Queue
    {
        protected class QueueNode
        {
            internal int data;
            internal QueueNode next;
            internal QueueNode(int data)
            {
                this.data = data;
            }
        }
        protected QueueNode tail;
        protected QueueNode head;
        public Boolean isEmpty()
        {
            return head == null;
        }
        public int Peek()
        {
            return head.data;
        }
        public void Add(int data)
        {
            QueueNode node = new QueueNode(data);
            if (head == null)
            {
                head = node;
            }
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
        }
        public int Remove()
        {
            int data = head.data;
            head = head.next;

            if (head == null)
            {
                tail = null;
            }
            return data;
        }

    }
}
