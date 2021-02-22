using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Recursion
    {
        public static void SumOfDigits(int n)
        {
            Console.WriteLine(SD(n, 0));
        }
        static int SD(int n, int total)
        {
            if (n <= 0) return 0;
            if (n > 0)
            {
                total = n % 10 + SD(n / 10, total);
            }
            return total;
        }

        public static void NoOfDigits(int n)
        {
            Console.WriteLine(ND(n));
        }
        static int ND(int n)
        {
            if (n < 10) return 1;
            return 1 + ND(n / 10);
        }

        internal static void Print1toN(int v)
        {
            if (v == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Print1toN(v - 1);
            Console.WriteLine(v);
        }
        internal static void PrintNto1(int v)
        {
            if (v == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine(v);
            PrintNto1(v - 1);
        }

        //Same logic can apply to Stack sorting
        internal static List<int> SortArr(List<int> v)
        {
            if (v.Count == 1) return v;
            int temp = v[v.Count - 1];
            v.RemoveAt(v.Count - 1);
            SortArr(v);
            Insert(v, temp);
            return v;
        }

        private static void Insert(List<int> v, int temp)
        {
            if (v.Count == 0 || v[v.Count - 1] < temp)
            {
                v.Add(temp);
                return;
            }
            int val = v[v.Count - 1];
            v.RemoveAt(v.Count - 1);
            Insert(v, temp);
            v.Add(val);
        }

        internal static Stack<int> RemoveMidInStack(Stack<int> stack, int n)
        {
            int size = stack.Count;
            if ((size == (n / 2) + 1))
            {
                stack.Pop();
                return stack;
            }
            else
            {
                int temp = stack.Pop();
                RemoveMidInStack(stack, n);
                stack.Push(temp);
                return stack;
            }

        }

        internal static Stack<int> ReverseStack(Stack<int> stack)
        {
            if (stack.Count == 0) return stack;
            int temp = stack.Pop();
            ReverseStack(stack);
            //Push to bottom of Stack
            pushToBottom(stack, temp);
            return stack;
        }
        static void pushToBottom(Stack<int> stack, int temp)
        {
            if (stack.Count == 0)
            {
                stack.Push(temp);
                return;
            }
            var val = stack.Pop();
            pushToBottom(stack, temp);
            stack.Push(val);
        }

        internal static void PrintSubsetUpperLower(string input, string output)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }

            if (input[0] - '0' >= 0 && input[0] - '0' <= 9)
            {
                string out1 = output + input[0];
                input = input.Remove(0, 1);
                PrintSubsetUpperLower(input, out1);
            }
            else
            {
                string out1 = output + new String(input[0], 1).ToUpper();
                string out2 = output + input[0];
                input = input.Remove(0, 1);
                PrintSubsetUpperLower(input, out1);
                PrintSubsetUpperLower(input, out2);
            }
            return;
        }

        internal static void PrintSubset(string input, string output)
        {
            if (input.Length == 0)
            {
                Console.WriteLine(output);
                return;
            }

            string out1 = output + input[0];
            string out2 = output;
            input = input.Remove(0, 1);
            PrintSubset(input, out1);
            PrintSubset(input, out2);

            return;
        }

        internal static void TOH(int s, int d, int h, int n)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disc {n} from {s} pole to {d}");
                return;
            }
            TOH(s, h, d, n - 1);
            Console.WriteLine($"Move disc {n} from {s} pole to {d}");
            TOH(h, d, s, n - 1);
            return;
        }

        internal static void Josephus(int n, int k)
        {

            //Your code here
            List<int> op = new List<int>();

            for (int q = 0; q < n; q++)
            {
                op.Add(q + 1);
            }
            int m = kill(k-1, 0, op);
            Console.WriteLine(m);
        }

        static int kill(int k, int index, List<int> op)
        {
            if (op.Count == 1)
            {
                return op[0];
            }
            index = (index + k) % op.Count;
            op.RemoveAt(index);
            kill(k, index, op);
            return op[0];
        }

        
    }
}
