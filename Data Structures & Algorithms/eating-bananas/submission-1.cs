public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int right = 0;
        int left = 1;
        foreach(int pile in piles){
            right = Math.Max(right, pile);
        }
        while(left<right){
            int mid = left+(right-left)/2;
            int hrs = 0;
            foreach(int pile in piles){
                hrs += (int)Math.Ceiling((double)pile/mid);
            }
            if(hrs<=h){
                right = mid;
            }
            else{
                left = mid+1;
            }
        }
        return left;
    }
}
