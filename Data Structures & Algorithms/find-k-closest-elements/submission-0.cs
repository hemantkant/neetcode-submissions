// 3️⃣ Optimal Approach (Binary Search on Window)
// ⏱ TC: O(log(n-k))
// 🧠 SC: O(1) (excluding output)
// 💡 Key Insight (VERY IMPORTANT)

// Instead of finding elements…

// 👉 We find starting index of window of size k

// 🔹 Think like this:

// We want window [l, l+k]

// Compare:

// x - arr[mid]  vs  arr[mid+k] - x

// 👉 If left side is bigger → move right
// 👉 Else → stay left

public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
    int right = arr.Length - k;

    while (left < right) {
        int mid = left + (right - left) / 2;

        if (x - arr[mid] > arr[mid + k] - x) {
            left = mid + 1;
        } else {
            right = mid;
        }
    }

    List<int> result = new List<int>();
    for (int i = left; i < left + k; i++) {
        result.Add(arr[i]);
    }
    return result;
    }
}