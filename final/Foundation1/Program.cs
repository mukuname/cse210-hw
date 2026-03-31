using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C#", "Code Academy", 600);
        Video video2 = new Video("OOP Explained", "Tech Guru", 800);
        Video video3 = new Video("Abstraction in Programming", "Dev Simplified", 500);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));

        // Add comments to video 2
        video2.AddComment(new Comment("David", "OOP finally makes sense."));
        video2.AddComment(new Comment("Emma", "Nice and clear."));
        video2.AddComment(new Comment("Frank", "Could use more examples."));

        // Add comments to video 3
        video3.AddComment(new Comment("Grace", "Abstraction is easier now."));
        video3.AddComment(new Comment("Henry", "Well explained topic."));
        video3.AddComment(new Comment("Ivy", "Thanks for this video!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display all videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}