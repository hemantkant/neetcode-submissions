public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i<nums.Length;i++){
            int sub = target - nums[i];
            if(dict.ContainsKey(sub)){
                return new int[]{dict[sub], i};
            }
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = i;
            }
        }
        return new int[0];
    }
}
