public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] newArr = new int[len*2];
        for(int i = 0; i<2*len; i++){
            newArr[i] = nums[i%len];
        }
        return newArr;
    }
}