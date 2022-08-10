public class Solution {
         public void Rotate(int[] nums, int k) {
         int len=nums.Length;
         k=k>len?k%len:k;
         if(k==len||k==0)
             return;
         int[] temp=new int[k];
         //temp=nums.Take(k);
         int indextemp=len-k;
                        Console.WriteLine("{0},{1},{2}",len,k,indextemp);

         for(int i=0;i<k;i++){
          // indextemp=len-(k-i)<len?len-(k-i):--indextemp;
            temp[i]=nums[i];
            nums[i]=nums[len-(k-i)];
           //Console.WriteLine(string.Join(",", temp));
      //      Console.WriteLine(string.Join(",", nums));
         }
         indextemp=0;int temp2=0;
         for(int i =k;i<len;i++){
             temp2=temp[indextemp];
             temp[indextemp]=nums[i];
             nums[i]=temp2;
             indextemp=indextemp>=(k-1)?0:++indextemp;
                   //   Console.WriteLine(indextemp);

   // Console.WriteLine(string.Join(",", nums));
         }
      
    }
    
//     private void Rotate(int [] nums){
//         int len=nums.Length;
//         // k=k>len?k%len:k;
//          int temp =nums[0];
//                 swap(ref nums[0],ref nums[len-1]);;
//         for(int i=1;i<len;i++){
//             temp=nums[i];
//             nums[i]=temp;
//             temp=temp2;
//         }
       
//     }
    // public void Rotate(int[] nums, int k) {
    //      int len=nums.Length;
    //       if(k==0 || k==len) return ;
    //      k=k>len?k%len:k;
    //     int index=len-k+1,counter=1;;
    //      swap(ref nums[len-k],ref nums[0]);
    //     while(counter<len-1){
    //       Console.WriteLine("F index={0},counter{1}",index,counter);
    //       swap(ref nums[index],ref nums[counter]);
    //         counter++;
    //         index= counter>=k?counter+1:len-k+counter;
    //           Console.WriteLine("ll index={0},counter{1}",index,counter);
    //           Console.WriteLine(string.Join(",", nums));
    //     }
    // }
        private void swap(ref int x,ref int y){
            int temp =x;
            x=y;
            y=temp;
        }
    }
// public class Solution {
//     public void Rotate(int[] nums, int k) {
//          int len=nums.Length;
//          if(k==0 || k==len) return ;
//         // var iseven=len%2==0&&k%2==0;
//          k=k>len?k%len:k;
//          int temp ,temp2;
//          int i=0,j=0,condition=len-k-i;
//           Console.WriteLine(len);

//           // while((iseven &&i<len-2)||(!iseven &&i<len-1))
//           while(i<len-1)
//             {                 
//               j=j==k?0:j;
//                 temp =nums[i];
//                 nums[i]=nums[len+j-k];
//                 nums[len+j-k]=temp;
//                 Console.WriteLine(string.Join(",", nums));
//                 // Console.WriteLine(j);

//               i++;
//               j++;
//             }
//     }
    
// }
 