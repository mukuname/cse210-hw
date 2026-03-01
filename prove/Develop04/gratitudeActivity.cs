using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Name someone you are grateful for.",
        "Name something simple that makes you happy.",
        "Name a challenge that helped you grow.",
        "Name something you are thankful for today."
    };

    public GratitudeActivity()
        : base("Gratitude",
        "This activity will help you focus on gratitude and positive thinking.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
            Console.Write("> ");
            Console.ReadLine();
        }

        EndMessage();
    }
}