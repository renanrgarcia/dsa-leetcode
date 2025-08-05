var str1 = "ABCABC";
var str2 = "ABC";

var result = GcdOfStrings(str1, str2);

Console.WriteLine(result); // Output: "ABC"

string GcdOfStrings(string str1, string str2)
{
    List<string> stringList = [str1, str2];
    List<string> subStrings = new(2);

    foreach (string str in stringList)
    {
        int left = 0;
        int right = 0;
        int maxLength = 0;
        HashSet<char> charSet = new HashSet<char>();

        while (right < str.Length)
        {
            if (!charSet.Contains(str[right]))
            {
                charSet.Add(str[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            else
            {
                charSet.Remove(str[left]);
                left++;
            }
        }
        string result = new string(charSet.ToArray());
        subStrings.Add(result);
    }

    if (subStrings[0] == subStrings[1])
    {
        return subStrings[0].ToString();
    }
    return "";
}

