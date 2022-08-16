public class Solution {
    public int MyAtoi(string s) {
        int res=0;
        bool isSign=false,isNag=false;
        string snum="";
        bool stopLoop=false;
        int i=0;
        while(!stopLoop&&i<s.Length){
            if((byte)s[i]>=48 && (byte)s[i]<=57){
                snum+=s[i];
            }else if(((byte)s[i]==45)&& snum==""&&!isSign){
                isNag=true;
                isSign=true;
            }else if(((byte)s[i]==43 )&&snum==""&&!isSign){
                isSign=true;
            }else if(((byte)s[i]!=32) || isSign || snum!=""){
                stopLoop=true;
            }
            i++;
        }
        if(snum=="")
            return 0;
        // Console.WriteLine("snum ={0}",snum);
        //  if(isNag&&isPositive){
        //         return 0;
        // }
        if(double.Parse(snum)>int.MaxValue){
            if(isNag){
                return int.MinValue;
            }else{
                return int.MaxValue;
            } 
        }
        else{
            if(isNag){
                return int.Parse(snum)*-1;
            }else{
                return int.Parse(snum);
            } 
        }
        // res=(double.Parse(snum)>int.MaxValue )?sign==1?int.MaxValue:int.MinValue:int.Parse(snum)*sign;
        // return res;
    }
}