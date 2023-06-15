class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Start() // https://www.w3schools.com/cs/cs_polymorphism.php
    {
        base.Start();

        Console.WriteLine("Activity in progress...");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.Write("Press ENTER to start listing...");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Collect user input
        int itemCount = 0;
        string input;
        do
        {
            input = Console.ReadLine();
            itemCount++;
        }
        while (DateTime.Now < endTime);

        Console.WriteLine();
        Console.WriteLine($"Number of items listed: {itemCount}");

        base.End();
    }
}