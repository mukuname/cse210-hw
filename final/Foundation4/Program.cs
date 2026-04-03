using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running("03 Nov 2022", 30, 3.0);   // 30 min, 3 miles
        Activity cycling = new Cycling("03 Nov 2022", 45, 12.0);  // 45 min, 12 mph
        Activity swimming = new Swimming("03 Nov 2022", 40, 20);  // 40 min, 20 laps

        // Put them in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("------------------------------");
        }
    }
}