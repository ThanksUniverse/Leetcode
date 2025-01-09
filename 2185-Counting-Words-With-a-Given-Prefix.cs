public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (word.StartsWith(pref))
                count++;
        }
        return count;
    }
}