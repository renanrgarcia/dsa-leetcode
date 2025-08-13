int[] flowerbed = [1, 0, 0, 0, 1];
int n = 2;

Console.WriteLine(CanPlaceFlowers(flowerbed, n)); // Output: false

static bool CanPlaceFlowers(int[] flowerbed, int n)
{
    if (n == 0)
        return true;

    var arraySize = flowerbed.Length;

    for (var i = 0; i < arraySize; i++)
    {
        if (flowerbed[i] == 0)
        {
            bool emptyLeft = (i == 0) || (flowerbed[i - 1] == 0);
            bool emptyRight = (i == arraySize - 1) || (flowerbed[i + 1] == 0);

            if (emptyLeft && emptyRight)
            {
                flowerbed[i] = 1;
                n--;

                if (n == 0)
                    return true;
            }
        }
    }

    return n <= 0;
}