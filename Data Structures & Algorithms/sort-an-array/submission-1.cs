//TC:Avg → O(n log n)
//Worst → O(n²)
//SC: O(log n)
//Quick Sort
public class Solution {
    public int[] SortArray(int[] nums) {
        QuickSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void QuickSort(int[] nums, int low, int high) {
        if (low >= high) return;

        int pivotIndex = Partition(nums, low, high);

        QuickSort(nums, low, pivotIndex - 1);
        QuickSort(nums, pivotIndex + 1, high);
    }

    private int Partition(int[] nums, int low, int high) {
        int pivot = nums[high];
        int i = low - 1;

        for (int j = low; j < high; j++) {
            if (nums[j] <= pivot) {
                i++;
                Swap(nums, i, j);
            }
        }

        Swap(nums, i + 1, high);
        return i + 1;
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}