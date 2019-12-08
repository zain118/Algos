using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static ConsoleApp1.Queue;

namespace ConsoleApp1
{
    class BST
    {
        public class Node
        {
            internal int data;
            internal Node left;
            internal Node right;
            public Node(int data)
            {
                this.data = data;
            }
        }
        //Node root;
        public Node AddNewNodeRecursive(Node root, int data)
        {
            if (root == null)
            {
                Node n = new Node(data);
                root = n;
            }
            else
            {
                if (data <= root.data)
                {
                    root.left = AddNewNodeRecursive(root.left, data);
                }
                else
                {
                    root.right = AddNewNodeRecursive(root.right, data);
                }
            }
            return root;
        }
        public Boolean Search(Node root, int data)
        {
            if (root != null)
            {
                if (root.data == data) return true;
                else if (data > root.data) return Search(root.right, data);
                else return Search(root.left, data);
            }
            else
            {
                return false;
            }

        }
        public int Min(Node root)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    return Min(root.left);
                }
                else return root.data;
            }
            else return -1;
        }
        public int Max(Node root)
        {
            if (root != null)
            {
                if (root.right != null)
                {
                    return Max(root.right);
                }
                else return root.data;
            }
            else return -1;
        }
        public int TreeHeight(Node root)
        {
            if (root == null)
                return -1;
            int leftHeight = TreeHeight(root.left);
            int rightHeight = TreeHeight(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
        Queue<Node> q = new Queue<Node>();
        public void BreadthFirstTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                if (root.left != null) q.Enqueue(root.left);
                if (root.right != null) q.Enqueue(root.right);
            }
            if (q.Count != 0) BreadthFirstTraversal(q.Dequeue());
        }
        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }
        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.WriteLine(root.data);
                InOrderTraversal(root.right);
            }
        }
    }
}
