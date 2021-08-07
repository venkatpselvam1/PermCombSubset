using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_DuplicateValue_Subsets_Backtrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();
            var nums = new int[] { 1, 2, 2, 2 };
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

        public class Solution
        {
            IList<IList<int>> output= new List<IList<int>>();
            int k=0, n;
            public IList<IList<int>> subsets(int[] nums)
            {
                Array.Sort(nums);
                n = nums.Length;
                for (; k <= n; k++)
                {
                    BackTrack(0, new List<int>(), nums);
                }

                return output;
            }
            public void BackTrack(int first, List<int> curr, int[] nums)
            {
                if (curr.Count() == k)
                {
                    output.Add(curr.ToList());
                    return;
                }

                for (int i = first; i < n; i++)
                {
                    if (i > first && nums[i] == nums[i-1])
                    {
                        continue;
                    }

                    curr.Add(nums[i]);
                    BackTrack(i + 1, curr, nums);
                    curr.RemoveAt(curr.Count() - 1);
                }
            }
        }
    }
}
