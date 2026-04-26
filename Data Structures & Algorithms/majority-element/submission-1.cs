//TC: O(n)
//SC: O(n)
//hashmap soln
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int n = nums.Length;

        foreach (int num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }

            // Early check (optimization)
            if (map[num] > n / 2)
            {
                return num;
            }
        }

        return -1; // Not needed as per problem (guaranteed to exist)
    }
}