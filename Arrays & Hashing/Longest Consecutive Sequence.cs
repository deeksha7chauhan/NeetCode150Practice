#### USING HASHSET ####   ### •	Time complexity: O(n)    •	Space complexity: O(n) #######

public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        int longest =0;
        if (nums.Length == 0) 
        return 0;
        
        HashSet<int> numSet = new HashSet<int>(nums);
        {
            foreach( int num in nums)
            {
                if(!numSet.Contains(num-1)) //this checks if there is any smaller number than the current number if not then start teh sequence.
                {
                    int length = 1;
                    while(numSet.Contains( num + length))
                    {
                        length++;
                    }
                    longest = Math.Max(longest, length);

                }
            }
            return longest;
        }
       
    }
}
