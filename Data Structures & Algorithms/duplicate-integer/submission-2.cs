// Optimal Approach (HashSet)
// TC: O(n)
// SC: O(n)
// Idea
// Use a HashSet.
// If number already exists in set → duplicate
// Else add it
// HashSet lookup is O(1) average.

public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> set = new HashSet<int>();

        foreach(int num in nums)
        {
            if(set.Contains(num))
                return true;

            set.Add(num);
        }

        return false; 
    }
}