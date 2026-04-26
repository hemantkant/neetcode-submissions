// 3️⃣ ✅ Optimal Approach (HashSet — O(n))
// 💡 Core Idea (Very Important)

// Instead of sorting:

// Put all numbers in HashSet
// Only start counting if number is the start of a sequence

// How to detect start?

// A number is start if:

// num - 1 does NOT exist in set

// That means this number begins a sequence.
// Time Complexity (TC): O(n)
// Space Complexity (SC): O(n)

public class Solution {
    public int LongestConsecutive(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    HashSet<int> set = new HashSet<int>(nums);
    int longest = 0;

    foreach (int num in set)
    {
        // Only start if it's the beginning of a sequence
        if (!set.Contains(num - 1))
        {
            int currentNum = num;
            int currentStreak = 1;

            while (set.Contains(currentNum + 1))
            {
                currentNum++;
                currentStreak++;
            }

            longest = Math.Max(longest, currentStreak);
        }
    }

    return longest;
}
}
