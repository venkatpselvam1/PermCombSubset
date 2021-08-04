using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_UniqueSubsets_Backtrack
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
    class Solution
    {
        int k = 0;
        List<List<int>> output = new List<List<int>>();
        public void BackTrack(int first, List<int> curr, int[] nums)
        {
            if (curr.Count() == k)
            {
                output.Add(curr.ToList());
                return;
            }
            for (int i = first; i < nums.Length; i++)
            {
                curr.Add(nums[i]);
                BackTrack(i+1, curr, nums);
                curr.RemoveAt(curr.Count() - 1);
            }
        }
        public List<List<int>> subsets(int[] nums)
        {
            for (k = 0; k <= nums.Length; k++)
            {
                BackTrack(0, new List<int>(), nums);
            }
            return output;
        }
    }
}
