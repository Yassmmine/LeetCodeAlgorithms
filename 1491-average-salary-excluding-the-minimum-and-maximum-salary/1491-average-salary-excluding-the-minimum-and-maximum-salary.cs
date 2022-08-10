public class Solution {
    public double Average(int[] salary) {
        int min=salary[0];
        int max=salary[0];
        double avg=max;
        for(int i=1;i<salary.Count();i++){
            if(salary[i]>max){
                //avg-=max;
                max=salary[i];
                avg+=max;
            }else if(salary[i]<min){
                //avg-=min;
                min=salary[i];
                avg+=min;
            }else{
                avg+=salary[i];
            }
                    Console.WriteLine("max={0},min={1},avg={2}",max,min,avg);

        }
                Console.WriteLine("sum={0}",salary.Sum());
        // Console.WriteLine("max={0},min={1},avg={2}",max,min,avg);
                Console.WriteLine("(avg-max-min)={0}",(avg-max-min));

        // Console.WriteLine("max={0},min={1},avg={2}",max,min,avg);
        return (double)(avg-max-min)/(salary.Count()-2);
    }
}