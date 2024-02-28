/* You are given an array of integers, where each element represents the maximum number of steps that can be jumped going forward from that element. 
Write a function to return the minimum number of jumps you must take in order to get from the start to the end of the array.
For example, given [6, 2, 4, 0, 5, 1, 1, 4, 2, 9], you should return 2, as the optimal solution involves jumping from 6 to 5, and then from 5 to 9. 
*/

using System;

class IntArray
{
    public void ExecuteTask()
    {
        Random rnd = new();
        int[] intArray = new int[rnd.Next(10,20)];
        
        Console.WriteLine("This is the random generated integer array: ");
        for (int i=0; i < intArray.Length; i++)
        {
            intArray[i] = rnd.Next(1,9);
            Console.Write(intArray[i] + " ");
        }

        Console.WriteLine("\nThis is the amount of times a jump occurs: ");
        int jumps = searchClosestWay(intArray);
        Console.Write(jumps.ToString());
    }

    private int searchClosestWay(int[] intArray)
    {
        //reach the end of the array as fast as possible
        int arrLength = intArray.Length;
        if(arrLength<=1)
        {
            return 0;
        }
        
        int[] jumps = new int[arrLength];
        jumps[0] = 0;

        for(int i=1;i<arrLength;i++)
        {
          jumps[i] = int.MaxValue;
            for (int j = 0; j < i; j++)
            {
                if (j + intArray[j] >= i && jumps[j] != int.MaxValue)
                {
                    jumps[i] = Math.Min(jumps[i], jumps[j] + 1);
                }
            }
        }

        return jumps[arrLength - 1];
    }
}
