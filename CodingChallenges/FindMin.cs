/*
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand. 
Find the minimum element in O(log N) time. You may assume the array does not contain duplicates.

For example, given [5, 7, 10, 3, 4], return 3.
*/

class FindMin
{
    public void ExecuteTask()
    {
        int[] unsortedArr= {5,7,10,3,4};

        int min = FindMinimum(unsortedArr);
        Console.WriteLine("\nMinimum in Array is: {0}", min);
    }

    static private int FindMinimum(int[] unsortedArr)
    {
        int left = 0;
        int right = unsortedArr.Length -1;

        while (left<right)
        {
            int mid = left + (right - left)/2;

            if(unsortedArr[mid]>unsortedArr[right])
            {
                left = mid+1;
            }
            else
            {
                right = mid;
            }
        }
        return unsortedArr[left];
    }
}