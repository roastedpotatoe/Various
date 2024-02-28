using System;

class Program
{
    static void Main(string[] args)
    {
        SubscriberTracker tracker = new SubscriberTracker();
        tracker.ExecuteTask();
       
        Occurences occurences = new();
        occurences.ExecuteTask();

        Operators operators = new();
        operators.ExecuteTask();
        
        IntArray intarr = new();
        intarr.ExecuteTask();

        Product prodArray = new();
        prodArray.ExecuteTask();

        FindMin findMin = new();
        findMin.ExecuteTask();

        Sum sum = new();
        sum.ExecuteTask();
    }
}