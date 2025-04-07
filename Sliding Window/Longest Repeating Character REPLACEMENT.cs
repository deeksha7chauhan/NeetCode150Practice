#https://neetcode.io/problems/longest-repeating-substring-with-replacement
Solution :- 
public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int res = 0;

        int l = 0, maxf = 0;
        for (int r = 0; r < s.Length; r++) {
            if (count.ContainsKey(s[r])) {
                count[s[r]]++;
            } else {
                count[s[r]] = 1;
            }
            maxf = Math.Max(maxf, count[s[r]]);
            int window_size= r-l+1;

            while (window_size - maxf > k) {
                count[s[l]]--;
                l++;
                window_size = r - l + 1;
            }
            res = Math.Max(res, window_size);
        }

        return res;
    }
}
Time Complexity = O(n)
Space Complexity = O(m)
