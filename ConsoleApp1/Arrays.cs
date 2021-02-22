using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arrays
    {
        public static void BinarySearch(int[] arr, int t)
        {
            int low = 0;
            int high = arr.Length - 1;
            BSearch(arr, high, low, t);
            //************ Iterative Sol ************************
            //int mid = (high + low) / 2;
            //while (low <= high) {
            //    mid = (high + low) / 2;
            //    if (arr[mid] > t) high = mid - 1;
            //    else if (arr[mid] < t) low = mid + 1;
            //    else if((arr[mid] == t)) { Console.WriteLine(mid); break; }
            //}

        }
        public static void FindMissing(int[] arr) {
            int high = arr.Length - 1;
            int low = 0;
            Mis(arr, high, low);
        }
        static void Mis(int[] arr, int high, int low)
        {
            if (high < low) return;
            int mid = (high + low) / 2;
            if (low == mid + 1 || high == mid + 1)
            {
                Console.WriteLine(mid + 2);
                return;
            }
            if (mid+1 == arr[mid]) Mis(arr, high, mid + 1);
            if (arr[mid] > mid+1)
            {
                Mis(arr, mid - 1, low);
            }
           
             
        }
        static void BSearch(int[] arr, int high, int low, int t) {
            if (high < low) return;
            int mid = (high + low) / 2;
            if (arr[mid] > t) {
                BSearch(arr, mid - 1, low, t);
            }
            else if (arr[mid] < t)
            {
                 BSearch(arr, high, mid + 1, t);
            }
            else Console.WriteLine(mid);
        }

        public static void MoveZeroes(int[] arr, int n)
        {
            for (int k = 1; k < n; k++)
            {
                if (arr[k - 1] == 0)
                {
                    for (int j = k; j > 0; j--)
                    {
                        if (arr[j] != 0 && arr[j - 1] == 0)
                        {
                            int temp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = temp;
                        }
                        else
                            break;
                    }
                }
            }
            foreach (int i in arr)
                Console.WriteLine(i);

        }

        public static void MoveZeroesLinearTime(int[] arr, int n)
        {
            int count = 0;
            for (int k = 0; k < n; k++)
            {
                if (arr[k] != 0)
                {
                    int temp = arr[k];
                    arr[k] = arr[count];
                    arr[count] = temp;
                    count++;
                }

            }
            foreach (int i in arr)
                Console.WriteLine(i);

        }

        public static void MaxDiff(int[] arr)
        {
            // arr[j] - arr[i] should be max and j > i
            int min = 0;
            int maxdif = arr[1] - arr[0];
            for (int k = 1; k < arr.Length; k++)
            {
                if (maxdif < arr[k] - arr[min])
                    maxdif = arr[k] - arr[min];
                if (arr[min] > arr[k])
                    min = k;
            }
            Console.WriteLine(maxdif);
        }

        public static void FrequencySorted(int[] arr)
        {
            int count = 1;
            for (int k = 1; k < arr.Length; k++)
            {
                if (arr[k - 1] == arr[k])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(arr[k - 1] + "   " + count);
                    count = 1;
                }
            }
            if (arr[arr.Length - 1] != arr[arr.Length - 2])
                Console.WriteLine(arr[arr.Length - 1] + "   " + count);
        }

        public static void FrequencyUnSorted(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int k = 0; k < arr.Length; k++)
            {
                if (dict.ContainsKey(arr[k]))
                {
                    dict[arr[k]] = dict[arr[k]] + 1;
                }
                else
                {
                    dict.Add(arr[k], 1);
                }
            }
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(key + "  " + dict[key]);
            }
        }

        public static void StockBuySellMine(int[] arr)
        {
            int min = arr[0];
            int total = 0;
            for (int k = 1; k < arr.Length; k++)
            {
                if (min > arr[k])
                {
                    min = arr[k];
                }
                if (min < arr[k])
                {
                    if (k + 1 == arr.Length)
                    {
                        total += arr[k] - min;
                        break;
                    }
                    if (arr[k + 1] <= arr[k])
                    {
                        total += arr[k] - min;
                        min = arr[k + 1];
                    }

                }
            }
            Console.WriteLine(total);
        }

        public static void StockBuySellGFG(int[] arr)
        {
            int total = 0;
            for (int k = 1; k < arr.Length; k++)
            {
                if (arr[k - 1] < arr[k])
                {
                    total += arr[k] - arr[k - 1];
                }
            }
            Console.WriteLine(total);
        }

        public static void LongestEvenOdd(int[] arr)
        {
            int count = 1;
            int res = 0;
            bool shouldNextEven = arr[0] % 2 == 0 ? false : true;
            for (int k = 1; k < arr.Length; k++)
            {
                if (arr[k] % 2 == 0) {
                    if (shouldNextEven) {
                        count++;
                        shouldNextEven = !shouldNextEven;
                    }
                    else {
                        res = Math.Max(res, count);
                        shouldNextEven = false;
                        count = 1;
                    }
                        
                }
                else
                {
                    if (!shouldNextEven)
                    {
                        count++;
                        shouldNextEven = !shouldNextEven;
                    }
                    else
                    {
                        res = Math.Max(res, count);
                        shouldNextEven = true;
                        count = 1;
                    }
                }
            }
            res = Math.Max(res, count);
            Console.WriteLine(res);
        }

        public static bool RotatedSorted(int[] arr,int num) { //Wrong
            if (num == 1) return true;
            bool changePoint = false;
            bool OrderIncrease = arr[0] < arr[1] ? true : false;
            for (int k = 1; k < num - 1; k++)
            {
                if (arr[k] < arr[k + 1])
                {
                    if (OrderIncrease) continue;
                    else
                    {
                        if (changePoint) return false;
                        else
                        {
                            OrderIncrease = true;
                            changePoint = true;
                        }
                    }
                }
                else
                {
                    if (OrderIncrease)
                    {
                        if (changePoint) return false;
                        else
                        {
                            OrderIncrease = false;
                            changePoint = true;
                        }
                    }
                }
            }
            if (changePoint) return true;
            else return false;
        }

        public static void SmallestMisPos(int[] arr)
        {
            int minEle = 1;
            int size = arr.Length;
            for (int k = 0; k < size; k++)
            {
                if (arr[k] <= size && arr[k] > 0)
                    arr[arr[k] - 1] = -1;
            }

            for (int k = 0; k < size; k++)
            {
                if (arr[k] > 0)
                {
                    Console.WriteLine(k);
                    return;
                }
            }
            Console.WriteLine(size + 1);
        }
        public static int MaxCircularSubArray(int[] a) {
            int kad = kadane(a);
            int total = 0;
            for (int i = 0; i < a.Length; i++)
            {
                total += a[i];
            }
            int revKad = reverseKadane(a);
            
            return Math.Max(kad, total - revKad);
        }
        public static int reverseKadane(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
               a[k] = a[k] * -1;
            }

            return kadane(a);
        }

        public static int kadane(int[] a)
        {
            int highSum = a[0];
            int currSum = a[0];
            for (int k = 0; k < a.Length; k++)
            {
                currSum += a[k];
                if (currSum < a[k])
                {
                    currSum = a[k];
                }
                if (currSum > highSum)
                    highSum = currSum;
            }
            return (highSum);
        }
    }
}
