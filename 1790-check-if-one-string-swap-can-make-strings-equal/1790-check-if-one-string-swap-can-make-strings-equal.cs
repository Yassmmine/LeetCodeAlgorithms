public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1.Length!=s2.Length)
            return false;
        if(s1.Equals(s2))
            return true;
        //reverse
        var sb=new StringBuilder(s1);
        var temp=s1[0];
        var len=s1.Length;
        int count=0;
        for(int i=0;i<len;i++){
            // temp=s1[i];
            for(int j=i+1;j<len;j++){
                temp=sb[j];
                sb[j]=sb[i];
                sb[i]=temp;
                  Console.WriteLine("{0},{1},{2}",sb[i],sb[j],sb.ToString());
                if(s2.Equals(sb.ToString()))
                   return true;
                temp=sb[j];
                sb[j]=sb[i];
                sb[i]=temp;
                 Console.WriteLine("{0},{1},{2}",sb[i],sb[j],sb.ToString());
            }
        }
        // void swap(out ref char s1.out ref char s2)
        // for(int i=0;i<(len)/2;i++){
        //     temp=sb[i];
        //     sb[i]=sb[len-i-1];
        //     sb[len-i-1]=temp;
        //       Console.WriteLine("{0},{1},{2}",sb[i],sb[len-i-1],sb.ToString());
        //     if(sb[i]!=s2[i])
        //         return false;
        // }
        // Console.WriteLine("{0},{1},{2}",s2,sb.ToString(),s2.Equals(sb.ToString()));
        //    if(s2.Equals(sb.ToString()));
        //     return true;
        return false;
    }
}