public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 2) {
            return nums.Length;
        }
        var p1 = 2;
        for(var p2 = 2 ; p2 < nums.Length ; p2++)
        {
            if(nums[p2] != nums[p1-2]) {
                nums[p1] = nums[p2];
                p1++;
            }
        }
        return p1;
    }
}