public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Summarized plan:
        // 1. Create a new array of doubles with the length specified
        // 2. Set the first element of the array to the number
        // 3. Loop through the array and set each element to the number times the index
        // 4. Return the array

        // Step 1: Create a new array of doubles with the length specified
        double[] result = new double[length];

        // Step 2: Set the first element of the array to the number
        result[0] = number;

        // Step 3: Loop through the array and set each element to the number times the index
        for (int i = 1; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // Step 4: Return the array
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Summarized plan:
        // 1. Create a new list of integers with the same length as the input list
        // 2. Loop through the input list and set each element to the new list at the index of the element plus the amount
        // 3. Set the input list to the new list

        // Step 1: Create a new list of integers with the same length as the input list
        List<int> result = new List<int>(data.Count);

        // Step 2: Loop through the input list and set each element to the new list at the index of the element plus the amount
        for (int i = 0; i < data.Count; i++)
        {
            result.Add(data[(i + data.Count - amount) % data.Count]);
        }

        // Step 3: Set the input list to the new list
        data.Clear();
        data.AddRange(result);
    }
}
