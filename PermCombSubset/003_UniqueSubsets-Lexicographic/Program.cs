using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_UniqueSubsets_Lexicographic
{
    class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();
            var nums = new int[] { 1, 2, 3 };
            var ans = sln.subsets(nums);
            for (int i = 0; i < ans.Count; i++)
            {
                for (int j = 0; j < ans[i].Count; j++)
                {
                    Console.Write(ans[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Solution
    {
        public IList<IList<int>> subsets(int[] nums)
        {
            var ans = new List<IList<int>>();
            int n = nums.Length;
            var start = (int)Math.Pow(2, n);
            var end = Math.Pow(2, n+1);
            for (int i = start; i < end; i++)
            {
                var mask = Convert.ToString(i, 2);
                var curr = new List<int>();
                for (int k = 0; k < n; k++)
                {
                    if(mask[k+1]=='1')
                    {
                        curr.Add(nums[k]);
                    }
                }
                ans.Add(curr);
            }
            return ans;
        }
    }
}
