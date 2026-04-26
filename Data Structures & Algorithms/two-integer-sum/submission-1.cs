//TC: O(nlogn) - sorting
//SC: O(n)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var pairs = nums
        .Select((num, idx) => new { num, idx })
        .OrderBy(x => x.num)
        .ToList();

        int left = 0;
        int right = pairs.Count - 1;

        while (left < right)
        {
            int sum = pairs[left].num + pairs[right].num;

            if (sum == target)
            {
                int i = pairs[left].idx;
                int j = pairs[right].idx;
                return i < j ? new int[] { i, j } : new int[] { j, i };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new int[0];
    }
}
