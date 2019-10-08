/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return new int[] { dic[target - nums[i]], i };
            }
            else
            {
                dic[nums[i]] = i;
            }

        }
        return null;

        // var result = new int[2];
        // if (nums == null || nums.Length <= 1)
        // {
        //     return result;
        // }

        // Dictionary<int, int> map = new Dictionary<int, int>();

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     map.Add(target - nums[i], i);
        // }

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (map.ContainsKey(nums[i]))
        //     {
        //         var v = map[nums[i]];

        //         if (v != i)
        //         {
        //             result[0] = i + 1;
        //             result[1] = v + 1;
        //         }
        //     }
        // }

        // return result;
    }
}
// @lc code=end

