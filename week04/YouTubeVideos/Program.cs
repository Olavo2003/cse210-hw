using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learning C# in 10 Minutes", "CodeAcademy", 600);
        v1.AddComment(new Comment("Alice", "This helped a lot!"));
        v1.AddComment(new Comment("Bob", "I finally get classes now."));
        v1.AddComment(new Comment("Clara", "Nice and simple."));

        Video v2 = new Video("The Future of AI", "TechWorld", 420);
        v2.AddComment(new Comment("Dan", "Super interesting."));
        v2.AddComment(new Comment("Eve", "AI is the future!"));
        v2.AddComment(new Comment("Frank", "Good video."));

        Video v3 = new Video("Python vs C#: Which is Better?", "DevTalks", 530);
        v3.AddComment(new Comment("Grace", "I like Python more."));
        v3.AddComment(new Comment("Henry", "C# all the way!"));
        v3.AddComment(new Comment("Ivy", "Good comparison."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.ShowInfo();
        }
    }
}
