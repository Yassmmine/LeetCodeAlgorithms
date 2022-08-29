public class Solution {
    public bool IsSameAfterReversals(int num) {
        if(num==0 ||num<10)
            return true;
        if(num%10==0)
            return false;
        return true;
    }
}