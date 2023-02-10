public class Solution {
    public int HammingWeight(uint n) {
        int count=0;
        while(n!=0){
            count+=(int)n&1;
            Console.WriteLine($"Before: {Convert.ToString(n, toBase: 2)}");
            n=n>>1;
        }
        return count;
    }
}

// public class Solution {
//     public int HammingWeight(uint n) {
//         int count =0;
//         for(int i=0;i<32;i++){
//             count=(n)
//             n=n>>1;
//         }
//     }
// }

