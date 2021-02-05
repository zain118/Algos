using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AlgoStart
    {
        public static void Main(string[] args)
        {
            //LongestSubstringWithoutRepetition();
            //FindLastFirstIndex();
            //IsSumEqualsTarget();
            //FindSingle();
            //NonDecreasingArray();
            //MaxinStack();
            //int[] ar = new int[] { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146, 82, 28, 162, 92, 196, 143, 28, 37, 192, 5, 103, 154, 93, 183, 22, 117, 119, 96, 48, 127, 172, 139, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 };
            //List<int> arr = testc(ar, 42, 468, 5);
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //Console.WriteLine(Search(new int[] { 564, 567, 571, 574, 578, 583, 584, 588, 591, 594, 596, 604, 611, 619, 622, 625, 632, 637, 639, 640, 642, 644, 650, 652, 658, 660, 663, 666, 667, 668, 673, 674, 678, 680, 683, 686, 694, 699, 709, 716, 717, 719, 721, 723, 727, 730, 736, 761, 762, 763, 775, 777, 778, 784, 788, 791, 794, 798, 806, 814, 815, 816, 821, 824, 826, 828, 829, 834, 840, 845, 851, 852, 853, 854, 857, 858, 860, 861, 869, 872, 876, 878, 887, 889, 891, 893, 899, 903, 911, 913, 920, 929, 931, 932, 933, 934, 949, 950, 953, 955, 956, 957, 958, 961, 963, 968, 970, 971, 973, 977, 978, 981, 982, 983, 986, 988, 990, 991, 992, 998, 1000, 1, 3, 9, 11, 12, 16, 17, 18, 20, 22, 30, 31, 33, 38, 40, 43, 51, 53, 54, 58, 63, 68, 70, 72, 76, 82, 84, 85, 87, 88, 98, 100, 101, 105, 110, 113, 115, 117, 123, 126, 127, 128, 132, 134, 135, 137, 141, 142, 148, 150, 153, 154, 155, 156, 157, 160, 161, 171, 172, 173, 174, 175, 180, 182, 184, 185, 190, 193, 196, 198, 199, 200, 208, 212, 217, 218, 224, 225, 226, 232, 239, 246, 255, 264, 265, 267, 270, 279, 281, 282, 284, 286, 287, 290, 296, 297, 298, 299, 301, 305, 306, 309, 310, 311, 314, 315, 324, 326, 327, 335, 338, 339, 342, 344, 351, 352, 353, 355, 356, 359, 361, 362, 365, 369, 377, 378, 379, 383, 384, 394, 399, 400, 405, 413, 416, 419, 422, 425, 427, 429, 434, 438, 440, 446, 466, 469, 470, 473, 475, 476, 477, 483, 484, 486, 488, 490, 491, 492, 495, 497, 507, 512, 518, 526, 529, 533, 536, 538, 539, 540, 542, 549, 552, 553, 556, 560, 563 }, 281));
            //swap(13456, 27324);
            //var list = union(new int[] {1,1,1,1,1 }, new int[] {2,2,2,2,2 }, 5, 5);
            //var list = intersection(new int[] { 1, 1, 1, 1, 1 }, new int[] { 2, 2, 2, 2, 2 }, 5, 5);
            //string str = "100101";
            //for (int k = 0; k < str.Length; k++)
            //{
            //    if (str[k] != '0' && str[k] != '1') {
            //        Console.WriteLine(false);
            //    }

            //}
            //Console.WriteLine(true); ;
            //foreach (int k in list) {
            //    Console.WriteLine(k);
            //}
            //int n = 1247;
            //string res = "";
            //string[] roman = new string[]{ "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            //int[] num = new int[]{ 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            //while (n > 0)
            //{
            //    for (int k = 0; k < num.Length; k++)
            //    {
            //        if (n >= num[k])
            //        {
            //            res += roman[k];
            //            n = n - num[k];
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine(res);
            //string str = "APFGMRZXIFPSXKOQDRRQJBBZ";
            //int adder = Math.Max(str[0] - 'a', str[0] - 'A'); 
            //String residue = "";
            //for (int k = 0; k < 26; k++)
            //{
            //    if (str.Length < k + 1)
            //    {
            //        residue += (char)(k + adder + 'a');
            //    }
            //    else if (str[k] == k + adder + 'a' || str[k] == k + adder + 'A')
            //    {

            //    }
            //    else
            //    {
            //        residue += k + adder + 'a';
            //        adder++;
            //    }
            //}
            //Console.WriteLine(residue);
            //string a = "allergy"; string b = "allergi";
            //if (a.Length != b.Length) Console.WriteLine(false);
            //int[] arr = new int[256];
            //// Your code here
            //for (int k = 0; k < a.Length; k++)
            //{
            //    arr[a[k]]++;
            //}
            //for (int k = 0; k < b.Length; k++)
            //{
            //    arr[a[k]]--;
            //}
            //Array.Sort(arr);
            //if (arr[0] == 0 && arr[255] == 0) Console.WriteLine(true);
            //else Console.WriteLine(false);
            //string s = "251.00.0234.125";
            ////if (s.Length < 15 || s.Length > 15) Console.WriteLine(false + "length");
            //bool res = true;
            //int i = 0;
            //int k = 0;
            //string[] strs = s.Split('.');
            //if (strs.Length > 4) Console.WriteLine(false + "before while");
            ////for(int k=0;k<=s.Length;k++){
            //try
            //{
            //    while (k < 4)
            //{

            //        if (Convert.ToInt32(strs[k]) > 255) {

            //            res = false; break;

            //        }
            //        if (Convert.ToInt32(strs[k]) == 0 && strs[k].Length > 1) {
            //            res = false; break;
            //        }

            //        k++;



            //}
            //}
            //catch (Exception e)
            //{
            //    res = false;
            //    Console.WriteLine(false + "in excep");
            //}
            //Console.WriteLine(res);

            //int a = 25;int b = 45;
            //a ^= b; Console.WriteLine(a);
            // b ^= a; Console.WriteLine( b);
            // a ^= b;
            //Console.WriteLine(a +"   " + b);
            //Console.ReadLine();
            //long[] hist = { 1,2,3,4,5 };
            //Console.WriteLine(max(hist,5));
            //Console.ReadLine();

            //https://ide.geeksforgeeks.org/RQAyfdyM2Z - Spiral Array

            //var root = BST.AddNewIterative(null, 5);
            //BST.AddNewIterative(root, 60);
            //BST.AddNewIterative(root, 59);
            //BST.AddNewIterative(root, 2);
            //BST.InOrderTraversal(root);
            //var root1 = BST.AddNewNodeRecursive(null, 5);
            //BST.AddNewNodeRecursive(root1, 60);
            //BST.AddNewNodeRecursive(root1, 59);
            //BST.AddNewNodeRecursive(root1, 2);

            //int[] arr = {1,3,6,8,10,14,18,20,25 };
            //int[] arr2 = { 4, 8, 15, 18, 19,20,22,25,30,35 };
            //int[] arr3 = { 5,4,3,2,1 };


            //var n = BST.MinHeightBST(arr, null, 0, 8);
            //var n3 = BST.CreateBST(arr3, null, 0);
            ////BST.PreOrderTraversal(n3);
            //var list = BST.PreOrderTraversal(n3, new List<int>());
            //var dict = new Dictionary<int, int>();
            //int Counter = 0; int MaxCounter = 0; int maxItem = 0;
            //int cur = 0;
            //for (int k = 0; k < list.Count; k++) {
            //    if (k == 0) {
            //        cur = list[k];
            //        continue;
            //    }
            //    if (cur < list[k])
            //    {
            //        if (MaxCounter < Counter) {
            //            MaxCounter = Counter;
            //            maxItem = cur;
            //        }
            //        Counter = 0;
            //        cur = list[k];
            //    }
            //    else {
            //        Counter++;
            //    }
            //    if (k==list.Count -1) {
            //        if (MaxCounter < Counter)
            //        {
            //            MaxCounter = Counter;
            //            maxItem = cur;
            //        }
            //    }
            //}
            //Console.WriteLine(maxItem +"   "+MaxCounter);


            //int[] arr4 = { 15, 10, 30, 5, 12, 25, 35, 3, 6, 17, 28 };
            //var n4 = BST.CreateBST(arr4, null, 0);
            //BST.InOrderTraversal(n4);
            //List<int> lt = BST.BranchSum(n4, 0, new List<int>());
            //for (int k = 0; k < lt.Count; k++) Console.WriteLine(lt[k]);
            //BST.InvertTreeRecursive(n4);
            //Console.WriteLine("-----------------------------------------------------");
            //BST.InOrderTraversal(n4);

            //int[] arr5 = { 15, 10, 30, 5, 12, 25, 35, 3, 6, 17, 28 };
            //var n5 = BST.CreateBST(arr5, null, 0);
            //List<List<int>> ltt = BST.LineByLineLevelTraversal(n5);
            //foreach (List<int> item in ltt)
            //{
            //    Console.WriteLine("$");
            //    foreach (int nums in item)
            //    {
            //        Console.WriteLine(nums);
            //    }
            //}
            //dict = BST.Traversal(n2, dict);
            //foreach (int k in dict.Keys) {
            //    Console.WriteLine(k + "       " +dict[k]);
            //}
            //BST.InOrderTraversal(n);
            //Console.WriteLine(BST.Ceil(n,9));

            //int[] arr6 = { 15, 10, 30, 5, 12, 25, 35, 3, 6, 17, 28 };
            //var n6 = BST.CreateBST(arr6, null, 0);
            //BST.InOrderTraversal(n6);
            //Console.WriteLine("--------------------------");
            //BST.InorderTravUsingStack(n6);





            //*************************************************************        GRAPH ************************************************************************

            List<int[]> edges = new List<int[]>{ new int[] {0,1}, new int[] {0, 2}, new int[] { 1, 3 }, new int[] {2, 3}, new int[] { 3, 4}, new int[] {5, 6}, new int[] { 6, 7 } };

            List<List<int>> adj = Graph.CreateDirectedAdj(edges, 8);
            List<int> lt = Graph.bfsOfGraph(8, adj);
            //List<int>  lt = Graph.RecursiveDFS(8, adj);
            for (int k = 0; k < lt.Count; k++)
            {
                Console.WriteLine(lt[k]);
            }








        }


        //static void MaxInContiguousArray() {
        //    int[] arr = { 1, 2, 3, 1, 4, 5, 2, 3, 6 };
        //    Queue<int> q = new Queue<int>();
        //    int k = 4;
        //    int max = 0;
        //    int counter = 0;
        //    int 

        //}
        static long max(long[] hist, long n){
            Stack<int> st = new Stack<int>();
            int[] left_small = new int[(int)n];
            int[] right_small = new int[(int)n];
            for (int k = 0; k < n; k++)
            {
                if (st.Count() == 0)
                {
                    left_small[k] = -1;
                }
                else if (hist[k] > hist[st.Peek()])
                {
                    left_small[k] = st.Peek();
                }
                else
                {
                    
                    while (st.Count() > 0 && hist[k] <= hist[st.Peek()])
                    {
                        st.Pop();
                    }
                    if (st.Count() == 0)
                    {
                        left_small[k] = -1;
                    }
                    else if (hist[k] > hist[st.Peek()])
                    {
                        left_small[k] = st.Peek();
                    }
                }
                st.Push(k);
            }
            st.Clear();
            for (int k = (int)n - 1; k >= 0; k--)
            {
                if (st.Count() == 0)
                {
                    right_small[k] = (int)n;
                }
                else if (hist[k] > hist[st.Peek()])
                {
                    right_small[k] = st.Peek();
                }
                else
                {
                    while (st.Count() > 0 && hist[k] <= hist[st.Peek()])
                    {
                        st.Pop();
                    }
                    if (st.Count() == 0)
                    {
                        right_small[k] = (int)n;
                    }
                    else if (hist[k] > hist[st.Peek()])
                    {
                        right_small[k] = st.Peek();
                    }
                }
                st.Push(k);
            }
            long max = 0;
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(left_small[k] + "   "+ right_small[k]);
                long area = (right_small[k] - left_small[k] - 1) * hist[k];
                max = max > area ? max : area;
                Console.WriteLine(area);
            }
            return max;
        }
    static void swap(long a, long b)
        {
            b = b * (int)Math.Pow(10, 6) + a;
            a = b / (int)Math.Pow(10, 6);
            b = b % ((int)Math.Pow(10, 6));


            Console.WriteLine(a + "            " + b);
        }

         static List<int> intersection(int[] arr1, int[] arr2, int n, int m)
        {
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < n && j < m)
            {

                if (arr1[i] == arr2[j])
                {
                    if (k == 0 || (k > 0 && list[k - 1] != arr1[i]))
                        list.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] > arr2[j])
                {
                    j++;
                    continue;
                }
                else
                {
                    i++;
                    continue;
                }

                k++;
            }
            if (list.Count == 0) list.Add(-1);
            return list;
        }
        static List<int> union(int[] arr1, int[] arr2, int n, int m) {
            List<int> list = new List<int>();
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < n && j < m)
            {
                if (k > 0 && list[k - 1] == arr2[j])
                {
                    j++;
                    continue;
                }
                if (k > 0 && list[k-1] == arr1[i])
                {
                    i++;
                    continue;
                }
                if (arr1[i] < arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    list.Add(arr2[j]);
                    j++;
                }
                else
                {
                    list.Add(arr2[j]);
                    j++;
                    i++;
                }
                k++;
            }
            while (i <= n - 1)
            {
                if (k > 0 && list[k-1] == arr1[i])
                {
                    i++;
                    continue;
                }
                list.Add(arr1[i]);
                i++;
            }
            while (j <= m - 1)
            {
                if (k > 0 && list[k-1] == arr2[j])
                {
                    j++;
                    continue;
                }
                list.Add(arr2[j]);
                j++;
            }
            return list;
        }
    
        static int Search(int[] array, int target)
        {
            // code here
            int n = array.Length;
            int peak = Peak(array, n);
            if (peak > n - 1 || peak < 0) return -1;
            if (array[peak] == target) return peak;
            if (target <= array[n - 1])
            {
                return Search(array, peak, n, target);
            }
            else if (target > array[n - 1])
            {
                return Search(array, 0, peak, target);
            }
            else
            {
                return peak;
            }
        }
        static int Search(int[] arr, int l, int r, int k)
        {

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == k)
                {
                    return mid;
                }
                if (arr[mid] > k)
                {
                    r = mid - 1;
                }
                if (arr[mid] < k)
                {
                    l = mid + 1;
                }

            }
            return -1;
        }
        static int Peak(int[] a, int n)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                //if(mid==0 || mid == n-1)
                //  return mid;
                if ((mid == 0 || a[mid - 1] <= a[mid]) && (mid == n - 1 || a[mid + 1] <= a[mid]))
                    return mid;

                if (mid > 0 && a[mid] <= a[mid - 1])
                {
                    r = mid - 1;
                }
                else 
                {
                    l = mid + 1;
                }

            }
            return -1;
        }







        public static int abc(int[] a, int n)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                //if(mid==0 || mid == n-1)
                //  return mid;
                if ((mid == 0 || a[mid - 1] <= a[mid]) && (mid == n - 1 || a[mid + 1] <= a[mid]))
                    return mid;

                if (mid > 0 && a[mid] < a[mid - 1])
                {
                    r = mid - 1;
                }
                if (mid < n - 1 && a[mid] < a[mid + 1])
                {
                    l = mid + 1;
                }

            }
            return -1;
        }
        static List<int> testc(int[] m, int n, int s, int y)
        {
            List<int> ls = new List<int>();
            
            // Your code here
            long sum = 0;
            int start = 0;
            int end = 0;
            int k = 0;
            while (k < n)
            {
                if (sum > s)
                {
                    sum -= m[start];
                    start++;
                }
                else if (sum < s)
                {
                    sum += m[k];
                    end = k;
                    k++;
                }
                else if (sum == s)
                {
                    break;
                }
                Console.WriteLine(k);
            }
            if (sum != s)
            {
                ls.Add(-1);
            }
            if (sum == s)
            {
                ls.Add(start + 1);
                ls.Add(end + 1);
            }
            return ls;
        }

        public static void LongestSubstringWithoutRepetition()
        {
            string str = "abcacghcturcnwovct";
            List<char> li = new List<char>();
            int max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!li.Contains(str[i]))
                {
                    li.Add(str[i]);
                }
                else
                {
                    int repInd = li.IndexOf(str[i]);
                    if (li.Count > max) max = li.Count;
                    int count = li.Count - repInd - 1;
                    li = li.GetRange(repInd + 1, count);
                    //List<char> liNew = new List<char>();
                    //for (int k = repInd + 1; k < li.Count; k++)
                    //    liNew.Add(li[k]);
                    //liNew.Add(str[i]);
                    //li = liNew;
                }
            }
            Console.WriteLine(max);
        }

        public static void FindLastFirstIndex()
        {
            int[] ints = new int[] { 1, 3, 5, 6, 7, 8, 10, 11, 15, 20 };
            int target = 9;
            int ans = -1;
            int left = 0;
            int right = ints.Length - 1;
            int midindex = (left + right) / 2;
            while (right >= left)
            {
                midindex = (left + right) / 2;
                if (ints[midindex] == target)
                {
                    ans = midindex;
                    break;
                }
                else if (ints[midindex] > target)
                {
                    right = midindex - 1;
                }
                else
                {
                    left = midindex + 1;
                }
            }
            int indexLeft = ans;
            int indexRight = ans;
            if (ans == -1) Console.WriteLine("Not Found");
            else
            {
                bool indexLeftDone = false, indexRightDone = false;
                while (indexLeft >= 0 && indexRight < ints.Length)
                {
                    if (ints[indexLeft - 1] == target) indexLeft--;
                    else indexLeftDone = true;
                    if (ints[indexRight + 1] == target) indexRight++;
                    else indexRightDone = true;
                    if (indexLeftDone && indexRightDone) break;
                }
            }
            Console.WriteLine($"Left Index : {indexLeft} Right : {indexRight}");
        }

        public static void IsSumEqualsTarget()
        {
            int target = 5;
            int[] ints = new int[] { 4, 7, 9, -3, 2 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            bool ans = false;
            for (int i = 0; i < ints.Length; i++)
            {
                if (dict.ContainsKey(target - ints[i]))
                {
                    ans = true;
                }
                else
                {
                    dict.Add(ints[i], target - ints[i]);
                }
            }
            Console.WriteLine(ans);
        }

        public static void FindSingle()
        {
            int[] ints = new int[] { 4, 3, 2, 4, 1, 1, 45, 3, 2 };
            int res = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                res = res ^ ints[i];
            }
            Console.WriteLine(res);
        }
        public static void NonDecreasingArray()
        {
            int[] ints = new int[] { 5, 1, 3, 2, 5 };
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (i == ints.Length - 1)
                {
                    break;
                }
                if (ints[i] > ints[i + 1])
                {
                    count++;
                }
                if (count == 2)
                {
                    break;
                }
            }
            if (count >= 2)
            {
                Console.WriteLine(false);
            }
            else Console.WriteLine(true);

        }

        public static void MaxinStack()
        {
            StackForMax s = new StackForMax();
            s.Push(1);
            s.Push(45);
            s.Push(5);
            s.Push(46);
            s.Push(100);
            s.Push(120);
            Console.WriteLine(s.Max());

            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine(s.Max());
        }
    }
    public class StackForMax
    {
        private List<int> MaxIndex;
        private int TopIndex = -1;
        int[] stackArr;
        public StackForMax()
        {
            stackArr = new int[10];
            MaxIndex = new List<int>();
        }
        public int Pop()
        {
            if (MaxIndex.LastOrDefault() == TopIndex) MaxIndex.RemoveAt(MaxIndex.Count - 1);
            return this.stackArr[TopIndex--];
        }
        public void Push(int value)
        {
            if (this.stackArr.Length - 1 <= TopIndex)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                TopIndex++;
                if (value > this.stackArr[MaxIndex.LastOrDefault()])
                {
                    MaxIndex.Add(TopIndex);
                }
                this.stackArr[TopIndex] = value;
            }
        }
        public int Max()
        {
            return this.stackArr[MaxIndex.LastOrDefault()];
        }
    }
}
