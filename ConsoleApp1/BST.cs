using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static ConsoleApp1.Queue;

namespace ConsoleApp1
{
    public static class BST
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
        public static Node AddNewNodeRecursive(Node root, int data)
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
        public static Node AddNewIterative(Node root, int data) {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
            }
            else {
                Node curr = root;
                while (true) {
                    if (data < curr.data) {
                        if (curr.left == null) {
                            curr.left = node;
                            break;
                        }
                        else {
                            curr = curr.left;
                        }
                       
                    }
                    else {
                        if (curr.right == null)
                        {
                            curr.right = node;
                            break;
                        }
                        else {
                            curr = curr.right;
                        }
                    }
                }
            }
            return root;
        }
        public static Boolean Search(Node root, int data)
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
        public static int Min(Node root)
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
        public static int Max(Node root)
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
        public static int TreeHeight(Node root)
        {
            if (root == null)
                return -1;
            int leftHeight = TreeHeight(root.left);
            int rightHeight = TreeHeight(root.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
        //static Queue<Node> q = new Queue<Node>();
        public static void BreadthFirstTraversal(Node root, Queue<Node> q)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                if (root.left != null) q.Enqueue(root.left);
                if (root.right != null) q.Enqueue(root.right);
            }
            if (q.Count != 0) BreadthFirstTraversal(q.Dequeue(), q);
        }
        public static void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }
        public static List<int> PreOrderTraversal(Node root, List<int> list)
        {
            if (root != null)
            {
                list.Add(root.data);
                PreOrderTraversal(root.left, list);
                PreOrderTraversal(root.right, list);
            }
            return list;
        }
        public static void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.WriteLine(root.data);
            }
        }
        public static void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.WriteLine(root.data);
                InOrderTraversal(root.right);
            }
        }
        public static Dictionary<int, int> Traversal(Node n, Dictionary<int, int> arr)
        {
            if (n == null) return arr;
            else
            {
                Traversal(n.left, arr);
                if (arr.ContainsKey(n.data))
                {
                    arr[n.data] = 2;
                }
                else
                {
                    arr.Add(n.data, 1);
                }
                //arr.put(n.data,);
                Traversal(n.right, arr);
            }
            return arr;
        }
        public static Node MinHeightBST(int[] arr, Node curr, int min, int max) {
            if (min > max) {
                return null;
            }
            int mid = (int) Math.Ceiling((decimal)((min + max) / 2));
            Node n = new Node(arr[mid]);

            if (curr == null) {
                curr = n;
            }
            else {
                //AddNewIterative(curr, arr[mid]); extra LogN time because of normal Traversal
                if (arr[mid] > curr.data) {
                    curr.right = n;
                    curr = curr.right;
                }
                else
                {
                    curr.left = n;
                    curr = curr.left;
                }
            }
            MinHeightBST(arr, curr, min, mid-1);
            MinHeightBST(arr, curr, mid+1, max);
            return curr;
        }

        public static Node CreateBST(int[] arr, Node curr, int ind)
        {

            //int mid = (int)Math.Ceiling((decimal)((min + max) / 2));
            if (ind >= arr.Length) return curr;
            Node n = new Node(arr[ind]);

            if (curr == null)
            {
                curr = n;
            }
            else
            {
                //AddNewIterative(curr, arr[mid]); extra LogN time because of normal Traversal
                AddNewIterative(curr, arr[ind]);
            }
            CreateBST(arr, curr, ind + 1);
            //MinHeightBST(arr, curr, mid + 1, max);
            return curr;
        }

        public static List<int> BranchSum(Node n, int runningSum, List<int> list) {
            if (n == null) return list;
            int newSum = runningSum + n.data;
            if (n.left == null && n.right == null) {
                list.Add(newSum);
                return list;
            } 
            BranchSum(n.left, newSum, list);
            BranchSum(n.right, newSum, list);
            return list;
        }

        public static int Closest(Node n, int target) {
            int minDiffItem = -1;
            int minDiff = Int32.MaxValue;
            while (n != null) {
                if (Math.Abs(target - n.data) < minDiff) {
                    minDiff = Math.Abs(target - n.data);
                    minDiffItem = n.data;
                }
                if (n.data < target)
                {
                    n = n.right;
                }
                else
                    n = n.left;
            }
            return minDiffItem;
        }
        public static int Floor(Node n, int target)
        {
            int minDiffItem = -1;
            int minDiff = Int32.MaxValue;
            while (n != null)
            {
                if ((target - n.data) >= 0 && (target - n.data) < minDiff)
                {
                    minDiff = (target - n.data);
                    minDiffItem = n.data;
                }
                if (n.data < target)
                {
                    n = n.right;
                }
                else
                    n = n.left;
            }
            return minDiffItem;
        }

        public static int Ceil(Node n, int target)
        {
            int minDiffItem = -1;
            int minDiff = Int32.MaxValue;
            while (n != null)
            {
                if ((n.data - target) >= 0 && (n.data - target) < minDiff)
                {
                    minDiff = (n.data - target);
                    minDiffItem = n.data;
                }
                if (n.data < target)
                {
                    n = n.right;
                }
                else
                    n = n.left;
            }
            return minDiffItem;
        }

        public static void InvertTree(Node n) {
            if (n == null) {
                return;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(n);
            while (q.Count != 0) {
                Node curr = q.Dequeue();
                Node temp = curr.left;
                curr.left = curr.right;
                curr.right = temp;
                if (curr.left != null) q.Enqueue(curr.left);
                if (curr.right != null) q.Enqueue(curr.right); 
            }
        }

        public static void InvertTreeRecursive(Node n)
        {
            if (n == null) return;
            Node curr = n;
            Node temp = curr.left;
            curr.left = curr.right;
            curr.right = temp;
            if (curr.left != null) InvertTreeRecursive(curr.left);
            if (curr.right != null) InvertTreeRecursive(curr.right);
        }

        public static List<List<int>> LineByLineLevelTraversal(Node node) {
            Queue<Node> q1 = new Queue<Node>();
            Queue<Node> q2 = new Queue<Node>();
            List<List<int>> ltt = new List<List<int>>();
            List<int> lt = new List<int>();
            if (node == null) return ltt;
            q1.Enqueue(node);
            int level = 1;
            while (q1.Count != 0 || q2.Count != 0)
            {
                Node n;
                if (level % 2 == 1)
                {
                    while (q1.Count != 0)
                    {
                        n = q1.Dequeue();
                        lt.Add(n.data);
                        if (n.left != null) q2.Enqueue(n.left);
                        if (n.right != null) q2.Enqueue(n.right);
                    }
                    ltt.Add(lt);
                }
                else
                {
                    while (q2.Count != 0)
                    {
                        n = q2.Dequeue();
                        lt.Add(n.data);
                        if (n.left != null) q1.Enqueue(n.left);
                        if (n.right != null) q1.Enqueue(n.right);
                    }
                    ltt.Add(lt);
                }
                //lt.Clear();
                lt = new List<int>();
                level++;
            }
            return ltt;
        }

        public static void InorderTravUsingStack(Node n) {
            if (n == null) return;
            Stack<Node> st = new Stack<Node>();
            while (n != null) {
                if (n.left != null)
                {
                    st.Push(n);
                    n = n.left;
                }
                else {
                    Console.WriteLine(n.data);
                    if (n.right != null)
                    {
                        st.Push(n.right);
                        n = n.right;
                    }
                    else {
                        if (st.Count != 0)
                        {
                            n = st.Pop();
                            Console.WriteLine(n.data);
                            n = n.right;
                        }
                        else break;
                    }
                   
                }
            }
        }
    }
}
