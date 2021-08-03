using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_UniqueSubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3};
            var ans = GetSubSets(nums);
            for (int i = 0; i < ans.Count; i++)
            {
                for (int j = 0; j < ans[i].Count; j++)
                {
                    Console.Write(ans[i][j]+", ");
                }
                Console.WriteLine();
            }
        }
        public static IList<IList<int>> GetSubSets(int[] arr)
        {
            var ans = new List<IList<int>>();
            ans.Add(new List<int>());
            foreach (var item in arr)
            {
                var newAns = new List<IList<int>>();
                foreach (var nums in ans)
                {
                    var cpy = nums.ToList();
                    cpy.Add(item);
                    newAns.Add(cpy);
                }
                ans.AddRange(newAns);
            }

            return ans;
        }
    }
}
