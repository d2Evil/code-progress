public class Solution {
    public int MajorityElement(int[] nums) {
        var candidate = 0;
        var count = 0;
        for (var i = 0; i < nums.Length; i++ ) {
            if(count == 0) {
                candidate = nums[i];
                count++;
            }
            else if( nums[i] == candidate) {
                count++;
            }
            else{
                count--;
            }
        }
        return candidate;
    }
}