//TC:O(2n) -> O(n) - 1 loop but twice
//SC:O(2n) - twice array size
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] numsTwice = new int[n*2];
        for(int i = 0; i<2*n; i++){
            numsTwice[i] = nums[i%n];
        }
        return numsTwice;
    }
}