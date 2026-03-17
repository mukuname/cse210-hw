using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        // Create some sample goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend temple", 50, 10, 500));

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest - Main Menu");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Score");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var goal in goals)
                    {
                        Console.WriteLine(goal.GetStatus());
                    }
                    break;

                case "2":
                    Console.WriteLine("Choose a goal to record:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].Name}");
                    }
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    int pointsEarned = goals[goalIndex].RecordEvent();
                    totalScore += pointsEarned;
                    Console.WriteLine($"You earned {pointsEarned} points!");
                    break;

                case "3":
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}