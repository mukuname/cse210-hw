using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you did something hard.",
        "Think of a time you helped someone.",
        "Think of a time you were brave."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?"
    };

    public ReflectionActivity()
        : base("Reflection",
        "This activity will help you reflect on your strengths.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(4);
        }

        EndMessage();
    }
}