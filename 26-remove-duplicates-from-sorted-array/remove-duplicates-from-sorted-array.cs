public class Solution {
    public int RemoveDuplicates(int[] nums) {
       if(nums.Length == 0) {return 0;}
        var p1=0;
        var p2=p1+1;
        while(p2 < nums.Length)
        {
            if(nums[p1] == nums[p2])
            {
                p2++;
            }
            else {
                p1++;
                nums[p1] = nums[p2];
                p2++;
            }
        }
        return p1+1;
    }
}