using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create a video with title, author, and length
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Clear explanation, I learned a lot!"));

        // Create another video
        Video video2 = new Video("Advanced C# Concepts", "Jane Smith", 600);
        video2.AddComment(new Comment("David", "I loved the deep dive into LINQ."));
        video2.AddComment(new Comment("Eve", "Could you explain delegates again?"));
        
        // Create another video
        Video video3 = new Video("C# Tips and Tricks", "John Doe", 400);
        video3.AddComment(new Comment("Frank", "The code optimization section was useful."));
        video3.AddComment(new Comment("Grace", "Could use more examples."));
        video3.AddComment(new Comment("Hannah", "I learned a lot, thanks for sharing."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display details about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            // Display each comment
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line between videos
        }
    }
}
