using System;

class SubscriberTracker
{
    private int[] subscribers;

    public SubscriberTracker()
    {
        subscribers = new int[24];
    }

    public void Update(int hour, int value)
    {
        subscribers[hour] += value;
    }

    public void ExecuteTask()
    {
                Random rnd = new Random();

        for(int i=0; i<24; i++)
        {
            Update(i, rnd.Next(100));
        }

        for(int i=0; i<24;i++)
        {
            if((i%3)==0 && i>0 || i == 23)
            {
                int subscribers = Query(i-3, i);
                Console.WriteLine("Subscribers for the hours {0} - {1}: {2}", i-3, i, subscribers);
            }
            
        }
    }

    public int Query(int start, int end)
    {
        int totalSubscribers = 0;
        for (int i = start; i <= end; i++)
        {
            totalSubscribers += subscribers[i];
        }
        return totalSubscribers;
    }
}
