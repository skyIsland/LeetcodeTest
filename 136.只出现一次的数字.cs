/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */

// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int res = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
            }
            else
                dict[num]++;
        }

        res = dict.FirstOrDefault(kv => kv.Value == 1).Key;

        return res;
    }
}
// @lc code=end

