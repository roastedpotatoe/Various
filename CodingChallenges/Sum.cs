/*
Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. 
Numbers can be 0 or negative.
For example, [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5.
 [5, 1, 1, 5] should return 10, since we pick 5 and 5.
Follow-up: Can you do this in O(N) time and constant space? 
*/

using System;

class Sum
{
    public void ExecuteTask()
    {

        Random rnd = new();
        int[] intArr = new int[rnd.Next(3,10)];
        Console.WriteLine("Here is the random generated array: ");
        for(int i=0; i<intArr.Length;i++)
        {
            intArr[i]=rnd.Next(1,10);
            Console.Write(intArr[i]+" ");
        }

        int incl = intArr[0];
        int excl=0;
        for(int i=1; i<intArr.Length; i++)
        {
            int temp = incl;
            incl = Math.Max(incl, excl + intArr[i]);
            excl = temp;
        }
    Console.WriteLine("\nSum of the array is: {0}", Math.Max(incl,excl));
    }
}