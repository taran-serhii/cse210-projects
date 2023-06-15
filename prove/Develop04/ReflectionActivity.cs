class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    public override void Start() // https://www.w3schools.com/cs/cs_polymorphism.php 
    {
        base.Start();

        Console.WriteLine("Activity in progress...");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions as they realted to this experience.");
        Console.WriteLine(); // Move to the next line

            for (int j = 4; j > -1; j--)
            {
                Console.CursorLeft = 0; // Position cursor at the beginning of the line
                Console.Write("           "); // Clear the line
                Console.CursorLeft = 0; // Position cursor at the beginning of the line
                Console.Write($"You may begin in...{j}");
                Thread.Sleep(1000); // Pause for 1 second
            }

        Console.Clear();

        for (int i = 0; i < _duration; i+=5)
        {
            string question = _questions[random.Next(_questions.Length)];

            Console.WriteLine(question);
            Spinner(5);
        }

        base.End();
    }
}