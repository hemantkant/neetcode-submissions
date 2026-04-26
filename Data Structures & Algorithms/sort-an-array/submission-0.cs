public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] nums, int left, int right){
        if(left>=right) return;
        int mid = left + (right-left)/2;
        MergeSort(nums, left, mid);
        MergeSort(nums, mid+1, right);
        Merge(nums, left, mid, right);
    }

    private void Merge(int[] nums, int left, int mid, int right){
        int[] temp = new int[right-left+1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right) {
            if (nums[i] <= nums[j])
                temp[k++] = nums[i++];
            else
                temp[k++] = nums[j++];
        }

        while (i <= mid)
            temp[k++] = nums[i++];

        while (j <= right)
            temp[k++] = nums[j++];

        for (int p = 0; p < temp.Length; p++) {
            nums[left + p] = temp[p];
        }
    }
}