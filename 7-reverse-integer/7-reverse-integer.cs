public class Solution {
    public int Reverse(int x) {
        int num=0,last=0;
        while(x!=0){
           // Console.WriteLine(num*10);
            last=x%10;
            num=num*10+last;
            x=x/10;
            // Console.WriteLine(num);
        } 
        if(num%10!=last)
            return 0;
        return num;
    }
}