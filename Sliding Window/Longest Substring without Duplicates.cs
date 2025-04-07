#When we encounter a repeating character, it means we need to shrink the window from the left until 
the repeating character is no longer in the window, as we are searching for substrings without repeating characters.

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new HashSet<char>();
        int l = 0;
        int res = 0;

        for (int r = 0; r < s.Length; r++) {
            while (charSet.Contains(s[r])) {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
