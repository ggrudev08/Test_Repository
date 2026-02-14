namespace Tomfoolery
{
    internal class Program
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int difference = target - nums[i];
                    if (!map.ContainsKey(nums[i]))
                    {
                        map[difference] = i;
                    }
                    else
                    {
                        return [map[nums[i]], i];
                    }

                }
                return [];
            }
        }

        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(string.Join(' ', solution.TwoSum([3, 4, 5, 6], 7)));
        }
    }
}
