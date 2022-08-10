public class Solution {
    public int CountOdds(int low, int high) {
        if(low==high)
            return low%2!=0?1:0;
        int count =low%2!=0?+1:0;
        count=high%2!=0?count+1:count;
        Console.WriteLine(count);
        if(count ==0)
          return  (high-low)/2 ;
        else
          return count+(high-low-1)/2;
    }
}