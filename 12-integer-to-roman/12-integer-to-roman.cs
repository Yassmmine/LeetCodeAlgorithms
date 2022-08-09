public class Solution {
    public string IntToRoman(int num) {
        IDictionary<int, string>  integertoRoman = new Dictionary<int, string>();
        integertoRoman.Add(1,"I"); 
        integertoRoman.Add(5,"V");
        integertoRoman.Add(10,"X");
        integertoRoman.Add(50,"L"); 
        integertoRoman.Add(100,"C");
        integertoRoman.Add(500,"D");        
        integertoRoman.Add(1000,"M");
        if(num==1)
            return integertoRoman[1];
        string res="";
        int temp;
        int count =0;
        if(num>=1000)
        {
            count=4;
        }
        else if(num>=100)
        {
            count=3;
        }
        else if(num>=10){
           count=2;
        }else {
            //Console.WriteLine("count=",count);
            count=1;
        }
       Console.WriteLine("res="+res);
        Console.WriteLine("count={0},num={1}",count,num);
        if(count==4){
            temp=(int)Math.Pow(10, count-1);
            int x=0;
                for(;x<(num/temp);x++)
                {
                    res+=integertoRoman[temp];
                }
                count--;
              num=num-temp*x;
        }
               Console.WriteLine("res="+res);

                Console.WriteLine("res={0},count={1},num={2}",res,count,num);

        if(count==3){
            if(num>=900){
                res+="CM";
                num=num-900;
            }else if(num>=500){
                temp=(int)Math.Pow(10, count-1);
                res+="D";
                num-=500;
                int x=0;
                for(;x<(num/temp);x++)
                {
                    res+=integertoRoman[temp];
                }
                // count--;
                num=num-temp*x;
        }else if(num>=400){
                res+="CD";
                num-=400;
            }else {
                temp=(int)Math.Pow(10, count-1);
                int x=0;
                for(;x<(num/temp);x++)
                {
                    res+=integertoRoman[temp];
                }
                // count--;
                num=num-temp*x;
            }
            count--;
        }       Console.WriteLine("res="+res);

                Console.WriteLine("res={0},count={1},num={2}",res,count,num);

        if(count==2){
             if(num>=90){
                res+="XC";
                num=num-90;
            }else if(num>=50){
                temp=(int)Math.Pow(10, count-1);
                res+="L";
                num-=50;
                int x=0;
                for(;x<(num/temp);x++)
                {
                    res+=integertoRoman[temp];
                }
                // count--;
                num=num-temp*x;
           }else if(num>=40){
                 res+="XL";
                num-=40;
            }else {
                temp=(int)Math.Pow(10, count-1);
                int x=0;
                for(;x<(num/temp);x++)
                {
                    res+=integertoRoman[temp];
                }
                // count--;
                num=num-temp*x;
            }
            count--;
        }       Console.WriteLine("res="+"jjjj");

                Console.WriteLine("res={0},count={1},num={2}",res,count,num);

        if(count==1){
              if(num>=9){
                res+="IX";
                num=num-9;
            }else if(num>=5){
                // temp=Math.Pow(10, count-1);
                res+="V";
                num-=5;
                int x=0;
                for(;x<num;x++)
                {
                    res+=integertoRoman[1];
                }
                // count--;
                num-=x;
           }else if(num>=4){
                 res+="IV";
                num-=4;
            }else {
                // temp=Math.Pow(10, count-1);
                int x=0;
                for(;x<(num);x++)
                {
                    res+=integertoRoman[1];
                }
                // count--;
                num-=x;
            }
            count--;
        }
        // if(num>1 && num<5)
        // {
        //     if((5-num)==1){
        //         for(int x=0;x<5-num;x++){
        //             res+=integertoRoman[1];
        //         }
        //         res+=integertoRoman[5];
        //     }else{
        //          for(int x=0;x<num;x++){
        //             res+=integertoRoman[1];
        //         }
        //     }
        // }
        // else if(nums>50&&nums<100){
        //     if((100-num)>=90){
        //         for(int x=0;x<num-90;x++){
        //             res+=integertoRoman[1];
        //         }
        //         res+=integertoRoman[5];
        //     }else{
        //          for(int x=0;x<num;x++){
        //             res+=integertoRoman[1];
        //         }
        //     }
        // }
        return res;
        
    }
}