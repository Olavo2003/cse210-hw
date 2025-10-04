using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        if (File.Exists("scriptures.txt"))
        {
            string[] lines = File.ReadAllLines("scriptures.txt");
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                    scriptures.Add(new Scripture(new Reference(parts[0], 1, 1), parts[1]));
            }
        }

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        int hidePerStep = 3;
        bool running = true;
        while (running)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllHidden())
            {
                running = false;
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(hidePerStep);
        }
    }
}
