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
        //MY COMMENTS:////
        //Multiples of (2,6) -> {2, 4, 6, 8, 10, 12}
        //1. Create an array of doubles with the size of length
        //2. Loop through the array and assign each element to be number * (index + 1)
        //3. Return the array


        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }
    //  Problem 1 End- 

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //  Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // MY COMMENTS:///
        //Rotate List Right (List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}, 3) -> List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        //1. Create a new list to hold the rotated values
        //2. Loop through the original list starting from the index of data.Count - amount and add each element to the new list until the end of the original list
        //3. Loop through the original list starting from the index of 0 and add each element to the new list until the index of data.Count - amount
        //4. Clear the original list and add the elements from the new list back to the original list   
    
        List<int> rotated = new List<int>();
        for (int i = data.Count - amount; i < data.Count; i++)        {
            rotated.Add(data[i]);
        }       
        for (int i = 0; i < data.Count - amount; i++)        {
            rotated.Add(data[i]);
        }
        data.Clear();
        data.AddRange(rotated);
    }
    //  Problem 2 End
}
