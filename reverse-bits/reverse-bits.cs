public class Solution {
    public uint reverseBits(uint n) {
        Console.WriteLine(n);
        uint res=0;int i=0;
        while(n>0 || i<=31){
            res<<=1;
            if((uint)(n&1)==1)
                res^=1;
            n>>=1;
                Console.WriteLine(n);
            i++;
        }
          // res<<=1;
        return res;
    }
}