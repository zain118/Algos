using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
//using static ConsoleApp1.LinkList;
using static ConsoleApp1.BST;
using Microsoft.SharePoint.Client;

namespace ConsoleApp1
{
    class Program
    {

        //public delegate bool del(int n);
        //public static bool Foo(int n)
        //{
        //    return n > 100;
        //}
        //public static bool Goo(int n)
        //{
        //    return n < 10;
        //}
        //public static IEnumerable<int> Run(IEnumerable<int> numbers, del func)
        //{
        //    foreach (int i in numbers)
        //    {
        //        if (func(i))
        //            yield return i;
        //    }
        //}

        //public class MooEventArgs : EventArgs
        //{
        //    string StateOfCow;
        //    public string StateOfCow1 { get => StateOfCow; set => StateOfCow = value; }

        //    public MooEventArgs(string state)
        //    {
        //        this.StateOfCow = state;
        //    }
        //}

        //public class Cow {
        //    public event EventHandler<MooEventArgs> Moo;
        //    public string Name { get; set; }
        //    public void EventRaised()
        //    {
        //        if(Moo != null)
        //        {
        //            Moo(this, new MooEventArgs("Dead"));
        //        }
        //    }
        //}
        //public static void giggle(Object sender, MooEventArgs args)
        //{
        //    Cow gotcha = sender as Cow;
        //    Console.WriteLine(gotcha.Name);
        //    if(args.StateOfCow1 == "Dead")
        //    {
        //        Console.WriteLine("Steeeeaks");
        //    }
        //}
        public static void callMe(Derived b) {

            b.No
        }

        public class Base {
            public int No;
        }
        public class Derived : Base {
            public int Yes;
        }

        public static void Main(string[] args)
        {

            Derived d = new Derived();
            Base b = new Base();
            callMe(d);
            Base c = new Derived();
            Derived e = new Base();


            //Cow betsy = new Cow { Name = "Betsy" };
            //betsy.Moo += giggle;
            //Cow georgy = new Cow { Name = "Georgy" };
            //georgy.Moo += giggle;
            //betsy.EventRaised();



            //    int[] numbers = new int[] { 1, 5, 8, 10, 12, 57, 100, 146, 125 };
            //    //del func = Foo;
            //    //func += Goo;
            //    IEnumerable<int> result;
            //    result = Run(numbers, n => n > 100);



            //    //foreach (del d in func.GetInvocationList())
            //    //{
            //    //    result.AddRange();
            //    //}

            //    foreach (int i in result)
            //    {
            //        Console.WriteLine(i);
            //    }



            //CalculateDiffMax();
            // Console.WriteLine(BracketsIsValid());


            //Queue q = new Queue();
            //Console.WriteLine(q.isEmpty());
            //Console.WriteLine(q.Peek());
            //q.Remove();
            //q.Add(2);
            //q.Add(78);
            //Console.WriteLine(q.Remove());
            //Console.WriteLine(q.Peek());


            //Stack s = new Stack();
            //s.Push(4);
            //s.Push(56);
            //Console.WriteLine(s.Peek());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Peek());

            //LinkList ll = new LinkList();
            //Console.WriteLine(ll.Add(3));
            //Console.WriteLine(ll.Add(4));
            //Console.WriteLine(ll.Add(5));
            //Console.WriteLine(ll.Add(10));
            //Console.WriteLine(ll.Add(15));
            //Console.WriteLine(ll.Add(20));
            //Console.WriteLine(ll.Add(25));
            //Console.WriteLine(ll.Add(30));
            //Console.WriteLine(ll.Add(35));
            //Console.WriteLine(ll.Add(40));
            //Node head = ll.Add(45);

            //Console.WriteLine(ll.GetElements(2, 3));
            //Console.ReadLine();
            //Node n = ll.Add(10);
            //Console.WriteLine("Deleted" + ll.DeleteAtPosition(4));
            //ll.PrintAll();

            //ll.ReverseList();

            //ll.PrintRecursive(n);
            //ll.PrintReverseRecursive(n);
            //Console.WriteLine(RecursionAdd(0));
            //Console.WriteLine(Sum(10));
            //ll.PrintAll();
            //ll.ReverseListRecursive(head);
            //ll.PrintAll();

            //DoublyLinkList dll = new DoublyLinkList();
            //dll.Add(5);
            //dll.Add(6);
            //dll.Add(7);
            //dll.Add(8);
            //dll.Add(9);
            //dll.Add(10);
            //dll.Add(11);
            //dll.PrintAll();
            //dll.DeleteAtPos(3);
            //dll.PrintAll();


            //BST bst = new BST();
            //Node root = null;
            //root = bst.AddNewNodeRecursive(root, 30);
            //root = bst.AddNewNodeRecursive(root, 67);
            //root = bst.AddNewNodeRecursive(root, 78);
            //root = bst.AddNewNodeRecursive(root, 69);
            //root = bst.AddNewNodeRecursive(root, 10);
            //root = bst.AddNewNodeRecursive(root, 89);
            //root = bst.AddNewNodeRecursive(root, 23);
            //root = bst.AddNewNodeRecursive(root, 15);
            //root = bst.AddNewNodeRecursive(root, 56);
            //root = bst.AddNewNodeRecursive(root, 5);
            //Console.WriteLine(bst.Search(root, 400));
            //Console.WriteLine(bst.Min(root));
            //Console.WriteLine(bst.Max(root));
            //Console.WriteLine(bst.TreeHeight(root));
            //bst.BreadthFirstTraversal(root);
            //bst.InOrderTraversal(root);




        }

        public static int RecursionAdd(int num)
        {

            if (num == 0)
            {
                return num;
            }
            return num + RecursionAdd(num - 1);
        }

        public static int Sum(int num)
        {
            if (num == 0) return 0; // exit condition
            return num + Sum(num - 1);
        }

        public static Boolean BracketsIsValid()
        {
            string str = "{([])}";
            Dictionary<char, char> pairs = new Dictionary<char, char>() { { '[', ']' }, { '(', ')' }, { '{', '}' } };
            List<char> stack = new List<char>();
            foreach (char c in str)
            {
                if (pairs.Values.Any(k => k == c))
                {
                    if (CheckIfMatches(c, pairs, stack))
                        stack.RemoveAt(stack.Count - 1);
                    else
                        stack.Add(c);
                }
                else
                {
                    stack.Add(c);
                }

            }
            if (stack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Boolean CheckIfMatches(char c, Dictionary<char, char> pairs, List<char> _stack)
        {
            char getChar;
            if (_stack.Count == 0)
                return false;
            pairs.TryGetValue((_stack[_stack.Count - 1]), out getChar);
            return getChar == c;
        }

        public static void CalculateDiffMax()
        {
            int start = 89; int end = 1908;
            List<int> l = new List<int> { 6, 78, 56, 567, 675, 79867, 343, 853, 1537 };
            l.Sort();
            List<int> redundant = l.Where<int>(x => x < start || x > end).ToList();

            l.RemoveAll(y => redundant.Contains(y));

            l.Insert(0, start);
            l.Insert(l.Count, end);

            int prev = 0;
            List<int> diff = new List<int>();
            for (int m = 0; m < l.Count; m++)
            {
                if (m == 0)
                {
                    prev = l[m];
                }
                if (m != 0)
                {
                    diff.Add(l[m] - prev);
                }

                prev = l[m];
            }
            Console.Write(diff.Max());
            Console.ReadLine();
        }
    }

}
