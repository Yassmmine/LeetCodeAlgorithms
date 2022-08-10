public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int result=1;
         int Count=nums.Count();
        int index=1;
         // Console.WriteLine("oldIndex={0}",oldIndex);
        int[] results=new int[Count];
        results[0]=nums[0];
           for(int i=1;i<Count;i++){
            if(nums[i-1]!=nums[i]){
                Console.WriteLine(string.Join(",", results));
                 Console.WriteLine("i={0}",i);

                results[index]=nums[i];
                result++;
                index++;
            }
           
             
        }
      
        results.CopyTo(nums,0);
        Console.WriteLine(string.Join(",,", nums));
        return result;
    }
    public void swap(ref int x,ref int y){
        int temp =x;
        x=y;
        y=temp;
    }
}