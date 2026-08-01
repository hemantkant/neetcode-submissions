public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dist = new HashSet<int>();
        foreach(int i in nums){
            if(dist.Contains(i)){
                return true;
            }
            dist.Add(i);
        }
        return false;
    }
}