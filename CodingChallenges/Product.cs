/* Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

Follow-up: what if you can't use division? */

using System;

class Product
{
    public void ExecuteTask()
    {

        Random rnd = new();
        int[] arr = new int[rnd.Next(3,6)];
        Console.WriteLine("This is the array: ");
        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = rnd.Next(1,10);
            Console.Write(arr[i]+" ");
        }

        int[] productArr = getProduct(arr);
        Console.WriteLine("\nThis is the product array: ");
        for(int i=0; i<productArr.Length; i++)
        {
            Console.Write(productArr[i]+" ");
        }

    }

    private int[] getProduct(int[] intArr)
    {
        int[] productArr = new int[intArr.Length];
        for(int i=0; i<intArr.Length; i++)
        {
            int prod = 1;
            for(int j=0; j<intArr.Length; j++)
            {
                if(j!=i)
                {
                    prod *=intArr[j];
                }
            }
            productArr[i]= prod;
        }

        return productArr;
    }
}