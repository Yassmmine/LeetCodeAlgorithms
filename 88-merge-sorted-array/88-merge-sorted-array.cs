public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int ptrm=m-1,ptrn=n-1,ptr=m+n-1;
        // if(n==0&&m==0)
        //     return;
        // List<int> temp=new();
        while(ptrm>=0&&ptrn>=0){
            if(nums1[ptrm]>nums2[ptrn]){
                nums1[ptr]=nums1[ptrm];
                ptrm--;
                
            }else{
                nums1[ptr]=nums2[ptrn];
                ptrn--;
            }
            ptr--;
       // Console.WriteLine("1m1={0},n1={1},num1={2}",ptrm,ptrn,String.Join(",",nums1));

        }
        while(ptrm>=0){
            
                nums1[ptr]=nums1[ptrm];
                ptrm--;
           
            ptr--;
                   // Console.WriteLine("2m1={0},n1={1},num1={2}",ptrm,ptrn,String.Join(",",nums1));

        }
        while(ptrn>=0){
           
                nums1[ptr]=nums2[ptrn];
                ptrn--;
           
            ptr--;
                   // Console.WriteLine("3m1={0},n1={1},num1={2}",ptrm,ptrn,String.Join(",",nums1));

        }
//         while(m1<m&&n1<n){
//            if(temp.Any() && temp[0]<nums2[n1]&& temp[0]<nums1[m1]){
//                if(temp[0]<nums1[m1])
//                    temp.Add(nums1[m1]);
//                nums1[m1]=temp[0];
//                temp.RemoveAt(0);
//                m1++;
               
//            }
//            else if(nums1[m1]>nums2[n1]){
//                temp.Add(nums1[m1]);
//                nums1[m1]=nums2[n1];
//                n1++;
//                m1++;
//            }else{
//               m1++;  
//            }
//             // Console.WriteLine("m1={0},n1={1},temp={2},nums1={3}",m1,n1,String.Join("; ", temp.ToArray()),String.Join(",",nums1));
//         }
//         // Console.WriteLine("m1={0},n1={1},temp={2},nums1={3}",m1,n1,String.Join("; ", temp.ToArray()),String.Join(",",nums1));

//         while(m1<(m+n) && m1>=m &&n1<n){
//            if((temp.Any()&&temp[0]<=nums2[n1])){
//                 if(temp[0]<nums1[m1])
//                     temp.Add(nums1[m1]);
//                   nums1[m1]=temp[0];
//                   temp.RemoveAt(0);
//                   m1++;
//            }else{
//              nums1[m1]=nums2[n1];
//                n1++;
//                m1++;  
//            }
//                     Console.WriteLine("m1={0},n1={1},temp={2},nums1={3}",m1,n1,String.Join("; ", temp.ToArray()),String.Join(",",nums1));

//         }

//         while(m1<(m+n) && m1<=m &&n1>n){
//          if((temp.Any()&&temp[0]>nums2[m1])){
//                nums1[m1]=nums2[m1];
//                // n1++;
//                m1++;
               
//            }else if((temp.Any()&&temp[0]<=nums2[m1])){
//                 if(temp[0]<nums1[m1])
//                      temp.Add(nums1[m1]);
//                    nums1[m1]=temp[0];
//                    temp.RemoveAt(0);
//                    m1++;
//                 // Console.WriteLine("m1={0},n1={1},temp={2},nums1={3}",m1,n1,String.Join("; ", temp.ToArray()),String.Join(",",nums1));
//            }
//         }
//        // Console.WriteLine("m1={0},n1={1},temp={2},nums1={3}",m1,n1,String.Join("; ", temp.ToArray()),String.Join(",",nums1));

//         while(m1<(m+n) &&temp.Any()){
        
//                 if(temp[0]<nums1[m1])
//                      temp.Add(nums1[m1]);
//                    nums1[m1]=temp[0];
//                    temp.RemoveAt(0);
//                    m1++;
//                 // Console.WriteLine("m1={0},n1={1},temp={2},nums1={3}",m1,n1,String.Join("; ", temp.ToArray()),String.Join(",",nums1));
          
//         }
       
    }
}