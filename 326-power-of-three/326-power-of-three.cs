public class Solution {
    public bool IsPowerOfThree(int n) {
          if (n==0 )
            return false;
        // n= Abs(n);
        while(n!=1){
            Console.WriteLine(n);
            if(n%3!=0)
                return false;
            else
             n=n/3;
        }
        return true;
    }
}

