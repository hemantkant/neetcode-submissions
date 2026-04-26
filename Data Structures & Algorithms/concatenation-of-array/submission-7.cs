public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] arr = new int[len*2];
        for(int i =0; i<2*len; i++){
            arr[i] = nums[i%len];
        }
        return arr;
    }
}