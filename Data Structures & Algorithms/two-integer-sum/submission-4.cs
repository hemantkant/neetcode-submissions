public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var pairs = nums.Select((num, indx)=> new {num, indx})
        .OrderBy(x=>x.num)
        .ToList();
        //Dictionary<int,int> dict = new Dictionary<int,int>();
        int left = 0;
        int right = nums.Length-1;
        while(left<right){
            int sum = pairs[left].num+pairs[right].num;
            if(target==sum){
                int i = pairs[left].indx;
                int j = pairs[right].indx ;
                return i<j ? new int[] {i,j}:new int[] {j,i};
            }
            if(sum<target){
                left++;
            }
            else{
                right--;
            }
        }
        // for(int i = 0; i<nums.Length; i++){
        //     int j = target - nums[i];
        //     if(dict.ContainsKey(j)){
        //         return new int[]{dict[j], i};
        //     }
        //     if(!dict.ContainsKey(nums[i])){
        //         dict[nums[i]] = i;
        //     }
            
        // }
        return new int[0];
    }
}
