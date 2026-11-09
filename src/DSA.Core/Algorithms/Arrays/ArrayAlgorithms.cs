public static class ArrayAlgorithms
{
     public static int FindMaximum(IReadOnlyList<int> numbers)
    {
        ArgumentNullException.ThrowIfNull(numbers);

        if (numbers.Count == 0)
        {
            throw new ArgumentException(
                "Collection cannot be empty.",
                nameof(numbers));
        }

        var maximum = numbers[0];

        for (var i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }

        return maximum;
    }
}