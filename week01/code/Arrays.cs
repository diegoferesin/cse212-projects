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

        // Step 1: Create a new array of doubles with the specified length
        // Step 2: Use a for loop to iterate from 0 to length-1
        // Step 3: For each index i, calculate the multiple as: number * (i + 1)
        //         - We use (i + 1) because we want multiples starting from 1, not 0
        //         - For example: if number=3 and i=0, we get 3*(0+1)=3
        //         - If i=1, we get 3*(1+1)=6, and so on
        // Step 4: Store each calculated multiple in the array at index i
        // Step 5: Return the completed array

        // Create array to store the multiples
        double[] multiples = new double[length];
        
        // Generate each multiple and store in the array
        for (int i = 0; i < length; i++)
        {
            // Calculate the (i+1)th multiple of the number
            multiples[i] = number * (i + 1);
        }
        
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Calculate the split point - this is where we divide the list
        //         The split point is data.Count - amount
        //         For example: if data has 9 elements and amount is 3, split point is 9-3=6
        //         This means elements 0-5 stay in place, elements 6-8 move to the front
        
        // Step 2: Extract the elements that need to move to the front using GetRange
        //         GetRange(split point, amount) gets the last 'amount' elements
        
        // Step 3: Extract the elements that stay in their relative positions using GetRange
        //         GetRange(0, split point) gets the first 'split point' elements
        
        // Step 4: Clear the original list to prepare for the new arrangement
        
        // Step 5: Add the rotated elements first (the ones that moved to the front)
        //         Then add the elements that stayed in their relative positions
        
        // Calculate where to split the list
        int splitPoint = data.Count - amount;
        
        // Extract the elements that need to move to the front (last 'amount' elements)
        List<int> elementsToMove = data.GetRange(splitPoint, amount);
        
        // Extract the elements that stay in their relative positions (first 'splitPoint' elements)
        List<int> elementsToKeep = data.GetRange(0, splitPoint);
        
        // Clear the original list
        data.Clear();
        
        // Add the rotated elements first, then the elements that stayed in place
        data.AddRange(elementsToMove);
        data.AddRange(elementsToKeep);
    }
}
