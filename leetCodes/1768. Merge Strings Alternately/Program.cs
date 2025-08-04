using System.Text;

Console.WriteLine(MergeAlternately("abc", "pqr")); // Output: "apbqcr"
Console.WriteLine(MergeAlternately("ab", "pqrs")); // Output: "apbqrs"
Console.WriteLine(MergeAlternately("abcd", "pq")); // Output: "apbqcd"

static string MergeAlternately(string word1, string word2)
{
    int i = 0;
    int j = 0;
    StringBuilder sb = new(word1.Length + word2.Length);


    while (i < word1.Length || j < word2.Length)
    {
        if (i < word1.Length)
        {
            sb.Append(word1[i]);
            i++;
        }

        if (j < word2.Length)
        {
            sb.Append(word2[j]);
            j++;
        }
    }

    return sb.ToString();
}