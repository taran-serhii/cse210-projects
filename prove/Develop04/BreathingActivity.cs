class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public override void Start() // https://www.w3schools.com/cs/cs_polymorphism.php
    {
        base.Start();

        Console.WriteLine("Activity in progress...");

        for (int i = 0; i < _duration; i+=8) // loop works until i is not bigger than entered duration, 
        // each cycle adds 8 seconds to i, since the breath in and breath out are set to 4 seconds each
        {
            Console.WriteLine(); // Move to the next line

            for (int j = 4; j > -1; j--)
            {
                Console.CursorLeft = 0; // Position cursor at the beginning of the line
                Console.Write("           "); // Clear the line
                Console.CursorLeft = 0; // Position cursor at the beginning of the line
                Console.Write($"Breathe in...{j}");
                Thread.Sleep(1000); // Pause for 1 second
            }

            //Console.Write($"Breathe in...");
            Console.WriteLine();

            for (int k = 4; k > -1; k--)
            {
                Console.CursorLeft = 0; // Position cursor at the beginning of the line
                Console.Write("           "); // Clear the line
                Console.CursorLeft = 0; // Position cursor at the beginning of the line
                Console.Write($"Now breathe out...{k}");
                Thread.Sleep(1000); // Pause for 1 second
            }

            Console.WriteLine();
        }

        base.End();
    }
}
