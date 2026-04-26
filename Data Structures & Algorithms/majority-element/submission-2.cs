// Approach 3: Optimal (Boyer-Moore Voting Algorithm)
// ⏱ Complexity
// TC: O(n)
// SC: O(1)

// 🔥 This is the most important one.
// 💡 Core Idea (VERY IMPORTANT)
// 👉 Majority element cancels out all other elements

// Think:
// Majority element count > all others combined

// So we:
// Keep a candidate
// Increase/decrease count

public class Solution {
    public int MajorityElement(int[] nums)
{
    int candidate = 0;
    int count = 0;

    foreach (int num in nums)
    {
        if (count == 0)
        {
            candidate = num;
        }

        if (num == candidate)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    return candidate;
}
}