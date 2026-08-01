public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i<nums.Length; i++){
            int j = target - nums[i];
            if(dict.ContainsKey(j)){
                return new int[]{dict[j], i};
            }
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = i;
            }
            
        }
        return new int[0];
    }
}
