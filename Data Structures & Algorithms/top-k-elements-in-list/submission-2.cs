// Approach 3 — Optimal (Bucket Sort)
// 🔥 This is the expected solution in interviews.

// ⏱ TC: O(n)
// 📦 SC: O(n)
// 💡 Key Insight
// Frequency can range from: // 1 → n

// So instead of sorting,
// we create an array of buckets where:

// index = frequency
// value = list of numbers with that frequency

public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    var freq = new Dictionary<int, int>();

    foreach (var num in nums)
    {
        if (freq.ContainsKey(num))
            freq[num]++;
        else
            freq[num] = 1;
    }

    List<int>[] buckets = new List<int>[nums.Length + 1];

    foreach (var kvp in freq)
    {
        int count = kvp.Value;
        if (buckets[count] == null)
            buckets[count] = new List<int>();

        buckets[count].Add(kvp.Key);
    }

    var result = new List<int>();

    for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
    {
        if (buckets[i] != null)
        {
            foreach (var num in buckets[i])
            {
                result.Add(num);
                if (result.Count == k)
                    break;
            }
        }
    }

    return result.ToArray();
}
}
