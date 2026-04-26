public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        map[0] = 1;
        int count = 0;
        int currentSum = 0;

        foreach(int num in nums){
            currentSum += num;
            if(map.ContainsKey(currentSum-k)){
                count += map[currentSum-k];
            }
            if(!map.ContainsKey(currentSum)){
                map[currentSum] = 0;
            }
            map[currentSum]++;
        }
        return count;
    }
}