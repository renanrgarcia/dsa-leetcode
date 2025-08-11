
var str1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
var str2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";

var result = GcdOfStrings(str1, str2);

Console.WriteLine(result);

static string GcdOfStrings(string str1, string str2)
{
    if (str1 + str2 != str2 + str1)
        return "";

    return str1[..GetGcd(str1.Length, str2.Length)];
}

static int GetGcd(int m, int n)
{
    while (n != 0)
    {
        int temp = n;
        n = m % n;
        m = temp;
    }

    return m;
}