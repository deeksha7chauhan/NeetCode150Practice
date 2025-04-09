--------------------------------------------------------------------------------------JAVA------------------------------------------------------------------------------------------
class Solution {
    public boolean checkInclusion(String s1, String s2) {
        if(s1.length() > s2.length())
            return false;
        int[] f1 = new int[26];
        int[] f2 = new int[26];
        for(char ch: s1.toCharArray()) {
            f1[ch - 'a'] += 1;
        }
        for(int i = 0; i < s1.length(); i++) {
            f2[s2.charAt(i) - 'a'] += 1;
        }
        if(isOk(f1, f2))
            return true;
        for(int i = s1.length(); i < s2.length(); i++) {
            f2[s2.charAt(i) - 'a'] += 1;
            f2[s2.charAt(i - s1.length()) - 'a'] -= 1;
            if(isOk(f1, f2))
                return true;
        }
        return false;
    }
    public boolean isOk(int[] f1, int[] f2) {
        for(int i = 0; i < f1.length; i++) {
            if(f1[i] != f2[i])
                return false;
        }
        return true;
    }
}
--------------------------------------------------------------------------------------C#------------------------------------------------------------------------------------------

    public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;

        int[] f1 = new int[26];
        int[] f2 = new int[26];

        foreach (char ch in s1) {
            f1[ch - 'a'] += 1;
        }

        for (int i = 0; i < s1.Length; i++) {
            f2[s2[i] - 'a'] += 1;
        }

        if (IsOk(f1, f2))
            return true;

        for (int i = s1.Length; i < s2.Length; i++) {
            f2[s2[i] - 'a'] += 1;
            f2[s2[i - s1.Length] - 'a'] -= 1;
            if (IsOk(f1, f2))
                return true;
        }

        return false;
    }

    private bool IsOk(int[] f1, int[] f2) {
        for (int i = 0; i < f1.Length; i++) {
            if (f1[i] != f2[i])
                return false;
        }
        return true;
    }
}


