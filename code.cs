public class Solution {
    public string RemoveOccurrences(string s, string part) {
        while(s.IndexOf(part) >= 0)
        {
            // while staring contains part, remove it
            s = s.Remove(s.IndexOf(part), part.Length);
        }
        return s;
    }
}
