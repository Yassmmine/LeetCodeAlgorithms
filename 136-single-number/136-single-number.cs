public class Solution {
    public int SingleNumber(int[] nums) {
        // var dict = new Dictionary<int,int>();
        int res=0;
        for(int i=0;i<nums.Length;i++){
            res ^=nums[i];
            //  if(dict.ContainsKey(nums[i]))  
            //     dict.Remove(nums[i]);
            // else 
            //     dict.Add(nums[i],nums[i]); 
        }
          // foreach(var i in dict.Keys)  return i; 
        return  res;// int.MaxValue;
    }
}