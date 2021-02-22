using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Strings
    {
        public static void GroupOfAnagrams(string[] words)
        {
            string[] sortedWords = new string[words.Length];
            int i = 0;
            foreach (string stri in words)
            {
                var ch = stri.ToCharArray();
                Array.Sort(ch);
                sortedWords[i] = new String(ch);
                i++;
            }
            List<List<string>> lt = new List<List<string>>();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int k = 0; k < sortedWords.Length; k++)
            {
                if (dict.ContainsKey(sortedWords[k]))
                {
                    lt[dict[sortedWords[k]]].Add(words[k]);
                }
                else
                {
                    lt.Add(new List<string>());
                    lt[lt.Count - 1].Add(words[k]);
                    dict.Add(sortedWords[k], lt.Count - 1);
                }
            }

            foreach (List<string> l in lt)
            {
                Console.WriteLine("**********************************");
                foreach (string s in l)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void substrings(string str) {
            int count = 0;
            for (int k = 0; k < str.Length - 1; k++)
            {
                if (str[k] == '1')
                {
                    for (int m = k + 1; m < str.Length - 1; m++)
                    {
                        if (str[m] == '1')
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static bool isRotated(string s1,string s2) {
            int r = 2;

            for (int k = 0; k < s2.Length; k++)
            {
                r = r % s1.Length;
                if (s2[k] != s1[r])
                {
                    return false;
                }
                r++;
            }
            return true;
        }

        public static int LeftIndexRepeated(string S) {
            Dictionary<Char, int> arr = new Dictionary<Char, int>();
            for (int k = 0; k < S.Length; k++)
            {
                if (arr.ContainsKey(S[k]))
                {
                    arr[S[k]]++; // = arr[S[k]] + 1;
                }
                else
                {
                    arr.Add(S[k], 1);
                }
            }
            foreach (var item in arr)
            {
                if (item.Value >= 2) return S.IndexOf(item.Key);
            } 

            return -1;
        }

        //Not Working
        public static char LeftIndexNonRepeat(string S) {
            //hqghumeaylnlfdxfircvscxggbwkfnqduxwfnfozvs

                 bool[] arr = new bool[260];
            char min = '$';
            for (int k = S.Length - 1; k >= 0; k--)
            {
                if (arr[S[k]] == true && S[k] == min)
                {
                    min = '$';
                }
                else if (arr[S[k]] == false)
                {
                    arr[S[k]] = true;
                    min = S[k];
                }
            }
            return min;
        }

        public static string reverseWords(string S)
        {
            // code here 
            char[] arr = S.ToCharArray();
            arr = reverse(arr, 0, arr.Length);
            int ind = 0;
            int k = 0;
            while (k < arr.Length)
            {
                if (arr[k] == '.')
                {
                    arr = reverse(arr, ind, k);
                    ind = k + 1;
                }
                k++;
            }
            return new String(arr);
        }

        static char[] reverse(char[] arr, int start, int end)
        {
            while (start < end) {
                char t = arr[start];
                arr[start] = arr[end-1];
                arr[end - 1] = t;
                start++;
                end--;
            }
            return arr;
        }

        
    }
}
