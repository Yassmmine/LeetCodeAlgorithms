public class Solution {
    public bool IsHappy(int n) { //19
        if(n<0)
            return false;
        var hash = new HashSet<int>();
        long prod=0;
        int num=0;
        while(n>1 &&!hash.Contains(n)){
            prod=0;
            num=n;
            hash.Add(n);
            Console.WriteLine("prod={0},num={1},n={2}",prod,num,n);
            while(num>0){ 
                prod+=(long)Math.Pow(num%10, 2); //82
                num=num/10;
           Console.WriteLine("prod={0},num={1},n={2}",prod,num,n);

            }
           hash.Add(n);

            n=(int)prod;
        }
        return n==1;
    }
}