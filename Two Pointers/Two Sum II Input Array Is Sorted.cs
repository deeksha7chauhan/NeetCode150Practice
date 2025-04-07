##### Two Pointer Solution ####
### Time complexity: O(n)
##Space complexity: O(1)

public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int l = 0;
        int r= numbers.Length-1;

        while(l<r)
        {
            int nowSum = numbers[l]+numbers[r];
            if(nowSum > target)
            {
                r--;
            }
            else if(nowSum < target)
            {
                l++;
            }
            else 
            {
                return new int[] {l+1, r+1};
            }
        }
        return new int[0];
        
    }
}


###HashMap Solution######
### Time complexity: O(n)
##Space complexity: O(n)

public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        Dictionary<int, int> mapping = new Dictionary<int, int>();
        for (int i=0; i<numbers.Length; i++)
        {
            int complement = target - numbers[i];
            if(mapping.ContainsKey(complement))
            {
                return new int[] {mapping[complement], i+1}; 
                //returns an array containing the two indices of the numbers that add up to the target.
            }
            mapping[numbers[i]]= i+1;
            //key=value
        }
        return new int[0]; 
    }
}

