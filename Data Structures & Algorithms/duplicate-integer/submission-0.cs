public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> checkDup = new HashSet<int>();
        foreach (int n in nums) {
            if (checkDup.Contains(n)) return true;
            checkDup.Add(n);
        }
        return false;
    }
}