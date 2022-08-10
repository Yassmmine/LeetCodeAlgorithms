public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        nums=nums.OrderByDescending(c => c).ToArray();;
        for(int i=1;i<nums.Length;i++){
            // for(int j=i+1;j<nums.Length;j++){
                if(nums[i]==nums[i-1])
                    return true;
            // }
        }
        return false;
    }
}