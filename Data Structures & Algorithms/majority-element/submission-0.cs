public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int candidate = 0;
        foreach(int num in nums){
            if(count==0){
                candidate = num;
            }
            if(candidate!=num){
                count--;
            }
            else{
                count++;
            }
        }
        return candidate;
    }
}