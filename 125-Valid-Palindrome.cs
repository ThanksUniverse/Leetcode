public class Solution {
    public bool IsPalindrome(string s) {
        string it = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return it == InvertString(it);
    }

    string InvertString(string s)
    {
        StringBuilder sb = new();
        for (int i = s.Length -1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}