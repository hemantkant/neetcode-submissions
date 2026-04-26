public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach(var num in nums){
        if(freq.ContainsKey(num)){
            freq[num]++;
        }
        else
        {
            freq[num] = 1;
        }
        }
        var sorted = freq.OrderByDescending(x=>x.Value)
                        .Take(k)
                        .Select(x=>x.Key)
                        .ToArray();
        return sorted;
    }
}
