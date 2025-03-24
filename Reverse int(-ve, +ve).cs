public class Solution {
    public int Reverse(int x) 
    {
        int revNum = 0;
       while (x != 0)
    {
        int digit = x % 10;
        if (revNum > int.MaxValue / 10 || (revNum == int.MaxValue / 10 && digit > 7))
            return 0; 
        
        if (revNum < int.MinValue / 10 || (revNum == int.MinValue / 10 && digit < -8))
            return 0; 
        revNum = revNum * 10 + digit;
        x /= 10;
    }
         return revNum;
        
    }
}
