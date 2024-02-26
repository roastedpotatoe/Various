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
    }
}