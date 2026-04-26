public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach(int num in set){
            if(!set.Contains(num-1)){
                int curNum = num;
                int curStreak = 1;
                while(set.Contains(curNum+1)){
                    curNum++;
                    curStreak++;
                }
                longest = Math.Max(longest, curStreak);
            }
            }
            return longest;
        }       

    }
    
