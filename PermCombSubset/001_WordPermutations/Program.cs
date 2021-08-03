using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_WordPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "aaca";
            var ans = new List<string>();
            GetPermutations(str, ans);
            for(int i = 0; i< ans.Count; i++)
            {
                Console.WriteLine((i+1)+" - "+ans[i]);
            }
        }
        public static void GetPermutations(string str, List<string> ans, int ind = 0)
        {
            if (ind == str.Length - 1)
            {
                ans.Add(str);
                return;
            }
            for (int i = ind; i < str.Length; i++)
            {
                var swappedStr = GetSwappedString(str, ind, i);
                if (i == ind || str[i] != str[ind])
                {
                    GetPermutations(swappedStr, ans, ind + 1);
                }
            }
        }
        public static string GetSwappedString(string str, int i, int j)
        {
            var arr = str.ToCharArray();
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return string.Concat(arr);
        }
    }
}
