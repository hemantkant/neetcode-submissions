// 3. OPTIMAL APPROACH (Two Pointers)

// 🔥 This is the expected solution.

// ⏱ TC:  O(n)

// 🗂 SC: O(1) ✅ (required)

// 💡 Core Idea

// Since the array is sorted:

// If sum is too small → move left pointer right
// If sum is too big → move right pointer left

// Because:

// Moving left pointer increases sum
// Moving right pointer decreases sum
// 🧠 Algorithm
// left = 0
// right = n - 1
// While left < right:
// sum = numbers[left] + numbers[right]
// if sum == target → return indices
// if sum < target → left++
// if sum > target → right--

public class Solution {
    public int[] TwoSum(int[] numbers, int target)
{
    int left = 0;
    int right = numbers.Length - 1;

    while(left < right)
    {
        int sum = numbers[left] + numbers[right];

        if(sum == target)
        {
            return new int[] { left + 1, right + 1 };
        }
        else if(sum < target)
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return new int[] {};
}
}
