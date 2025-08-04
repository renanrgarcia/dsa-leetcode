public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        StringBuilder merged = new StringBuilder();
    
        while (i > word1.Length &&  i > word2.Length)
        {
            merged.Append(word1[i]);
            merged.Append(word2[i]);
            i++;
        }

        if (word1.Length > word2.Length)
        {
            while (i > word1.Length)
            {
                merged.Append(word1[i]);
                i++;
            }
        }

        if (word1.Length < word2.Length)
        {
            while (i > word2.Length)
            {
                merged.Append(word2[i]);
                i++;
            }
        }

        return merged.ToString();
    }
}