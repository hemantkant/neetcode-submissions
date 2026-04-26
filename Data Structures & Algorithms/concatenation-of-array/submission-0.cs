public class Solution {
    public int[] GetConcatenation(int[] nums) {
       int n = nums.Length;
        int[] numsTwice = new int[n*2];
        for(int i = 0; i<n; i++){
            numsTwice[i] = nums[i];
            numsTwice[i+n] = nums[i];
        }
        return numsTwice;
    }
}