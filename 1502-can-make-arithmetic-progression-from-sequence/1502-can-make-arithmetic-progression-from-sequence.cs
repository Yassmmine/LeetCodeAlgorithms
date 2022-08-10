public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {  
        Array.Sort(arr);
        int seq=arr[0]-arr[1];
        int oldseq=-seq;
        for(int i=2;i<arr.Count();i++){
            seq=(arr[i]-arr[i-1]); 
            Console.WriteLine("{0},{1}",seq,oldseq);
            if(seq!=oldseq && seq!=-oldseq)
                return false;
        }
        return true;
    }
}