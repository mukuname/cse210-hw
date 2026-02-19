using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // This program gradually increases difficulty by hiding
        // more words each round instead of a fixed amount.

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";

        Scripture scripture = new Scripture(reference, text);

        string input = "";
        int round = 1;

        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScriptureText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            // Gradual difficulty: hide more words each round
            int wordsToHide = round * 2;
            scripture.HideRandomWords(wordsToHide);

            round++; // increase difficulty

            if (scripture.AllHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetScriptureText());
                Console.WriteLine();
                Console.WriteLine("Everything is hidden now. Program ending.");
                break;
            }
        }
    }
}
