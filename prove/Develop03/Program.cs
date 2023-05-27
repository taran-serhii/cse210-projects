using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         // Create a list of scriptures
        List<Scripture> scriptures = new List<Scripture>();

        // Add scriptures to the list
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("Amos", 3, 7), "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets."));
        scriptures.Add(new Scripture(new Reference("Malachi", 4, 5, 6), "Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the Lord:\nAnd he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse."));
        scriptures.Add(new Scripture(new Reference("John", 17, 3), "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent."));
        scriptures.Add(new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
        scriptures.Add(new Scripture(new Reference("3 Nephi", 11, 10, 11), "Behold, I am Jesus Christ, whom the prophets testified shall come into the world.\nAnd behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning."));
        scriptures.Add(new Scripture(new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\nAnd by the power of the Holy Ghost ye may know the truth of all things."));
        scriptures.Add(new Scripture(new Reference("Doctrine and Covenants", 1, 37, 38), "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled.\nWhat I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."));
        scriptures.Add(new Scripture(new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."));

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Get a random scripture");
            Console.WriteLine("2. Select a scripture from the list");
            Console.WriteLine("3. Exit");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ProcessScripture(GetRandomScripture(scriptures));
                    break;
                case 2:
                    Console.WriteLine("Select a scripture from the list:");
                    for (int i = 0; i < scriptures.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {scriptures[i].GetReference().DisplayReference()}");
                    }

                    if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > scriptures.Count)
                    {
                        Console.WriteLine("Invalid selection. Please try again.");
                        continue;
                    }

                    ProcessScripture(scriptures[selection - 1]);
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ProcessScripture(Scripture scripture)
    {
        while (true)
        {
            scripture.DisplayScripture();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to return to the menu.");

            if (Console.ReadLine()?.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words in the scripture are hidden.");
                break;
            }
        }
    }

     static Scripture GetRandomScripture(List<Scripture> scriptures)
    {
        Random random = new Random();
        int index = random.Next(0, scriptures.Count);
        return scriptures[index];
    }
}