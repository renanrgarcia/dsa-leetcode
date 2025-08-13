int[] candies = { 4, 2, 1, 1, 2 };
int extraCandies = 1;

Console.WriteLine(string.Join(", ", KidsWithCandies(candies, extraCandies)));

static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
{
    var greatest = candies.Max();
    bool[] result = new bool[candies.Length];

    for (var i = 0; i < candies.Length; i++)
    {
        result[i] = candies[i] + extraCandies >= greatest;
    }

    return result;
}