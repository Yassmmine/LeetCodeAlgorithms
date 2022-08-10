public class Solution {
    public int ArraySign(int[] nums) {
        long prod=1;
        
        foreach (int a in nums)
        {
            if(a==0)
                return 0;
            
            prod*=a>0?1:-1;
            //        Console.WriteLine("prod={0}",prod);

        };
      //  Console.WriteLine("prod={0}",prod);
        // if(prod==0)
        //     return 0;
        // else
        if(prod>0)
            return 1;
        else if(prod<0)
            return -1;
        
        return 0;
            
    }
}