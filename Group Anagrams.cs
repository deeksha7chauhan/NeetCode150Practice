public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var res= new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortS = new string(charArray);
            if(!res.ContainsKey(sortS))

            {
                res[sortS] = new List<string>();

            }
            res[sortS].Add(s);
        }

        return res.Values.ToList();
        
    }
}
