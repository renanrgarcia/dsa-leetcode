string s = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";

Console.WriteLine(LongestPalindrome(s));

static string LongestPalindrome(string s)
{
    var greater = "";
    var lengthS = s.Length;

    if (lengthS == 1)
        return s;

    for (var i = 0; i < lengthS; i++)
    {
        for (var j = 1; j <= lengthS - i; j++)
        {
            var reversedString = new string(s.Substring(i, j).Reverse().ToArray());
            if (s.Substring(i, j).Equals(reversedString))
            {
                greater = s.Substring(i, j).Length > greater.Length ? s.Substring(i, j) : greater;
            }
        }
    }

    return greater;
}