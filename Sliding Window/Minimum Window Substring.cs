public class Solution {
    public string MinWindow(string s, string t) {
        int n = s.Length;
        if (t.Length > n) return "";

        Dictionary<char, int> map = new Dictionary<char, int>();

        // Store frequency of characters in t
        foreach (char ch in t) {
            if (map.ContainsKey(ch)) map[ch]++;
            else map[ch] = 1;
        }

        int requiredCount = t.Length;
        int i = 0, j = 0;
        int minWindowSize = int.MaxValue;
        int start_i = 0;

        while (j < n) {
            char ch = s[j];

            if (map.ContainsKey(ch)) {
                if (map[ch] > 0) requiredCount--;
                map[ch]--;
            } else {
                map[ch] = -1; // track even if it's extra
            }

            while (requiredCount == 0) {
                int currWindowSize = j - i + 1;
                if (currWindowSize < minWindowSize) {
                    minWindowSize = currWindowSize;
                    start_i = i;
                }

                char startChar = s[i];
                if (map.ContainsKey(startChar)) {
                    map[startChar]++;
                    if (map[startChar] > 0) requiredCount++;
                }

                i++;
            }

            j++;
        }

        return minWindowSize == int.MaxValue ? "" : s.Substring(start_i, minWindowSize);
    }
}

#Time complexity: O(n)
#Space complexity: O(m)
