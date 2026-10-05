public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var p1 = 0;
        var p2 = nums.Length -1;
        while(p1<=p2) 
        {
            if(nums[p1] == val) {
                if(nums[p2] == val) {
                    p2--;
                }
                else
                {
                    nums[p1] = nums[p2];
                    p2--;
                    p1++;
                }
            } else
            {
                p1++;
            }

        } 
        return p1;
    }
}