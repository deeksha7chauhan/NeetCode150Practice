public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> s1 = new Dictionary<char, int>();
        Dictionary<char, int> t1 = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (s1.ContainsKey(c))
            {
                s1[c]++;
        
            }
            else
            s1[c]=1;
        }
        foreach (char c in t)
        {
            if (t1.ContainsKey(c))
            {
                t1[c]++;
        
            }
            else
            t1[c]=1;
        }
        return s1.Count==t1.Count && !s1.Except(t1).Any(); //s1.Except(t1)= will store key-val which aren't present in t1, Any() checks if there is any val in s1.Expect(t1), ! negates the statements which menas there should be no val in s1.Except(t1).Any(),ensures that s1 has no extra or different key-value pairs compared to t1, meaning both dictionaries are identical.
      

    }
}
