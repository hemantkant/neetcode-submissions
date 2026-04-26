// Optimal Approach (Greedy + Two Pointer)
// 💡 Core Logic:
// Sort array
// Pair lightest + heaviest
// If cannot → send heaviest alone
// ⏱ Complexity
// TC: O(n log n) (sorting)
// SC: O(1)

public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);

        int left = 0;
        int right = people.Length - 1;
        int boats = 0;

        while (left <= right) {
            if (people[left] + people[right] <= limit) {
                left++;
            }

            right--;
            boats++;
        }

        return boats;
    }
}