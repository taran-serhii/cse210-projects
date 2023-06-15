class Activity
{
    protected string _name { get; set; }  // https://www.w3schools.com/cs/cs_properties.php
    protected string _description { get; set; }
    protected int _duration { get; set; }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Start method, which is starting the activity by clearing the console, providing the anme and description of the activity,
    // and asks the user to specify duration. Then it displays the "Get ready" message and shows the spinner for 5 seconds.
    public virtual void Start()  // https://www.w3schools.com/cs/cs_polymorphism.php
    {
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(5);
    }

    // End method shows the closing message for the acitivty and displays the activity's duration. 
    // Then it also shows the spinner for 5 seconds.
    public void End()
    {
        Console.WriteLine("Good job!");
        Spinner(2);
        Console.WriteLine($"You have completed the {_name} activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
        Spinner(5);
    }

    // The Spinner method displays a spinner animation made out of 4 symbols changing each other in order.
    // THe method uses DateTime object to calculate the end of the animation.
    public void Spinner(int _duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        string[] spinner = { "\\", "|", "/", "—" };
        int index = 0;

        while (DateTime.Now < endTime) // the loop works until current time exceeds the endTime
        {
            Console.Write(spinner[index]); // display the first symbol
            Thread.Sleep(350); // Pause for 3500 milliseconds
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // move the cursor back
            index = (index + 1) % spinner.Length; // updating the index to swtich to the next symbol 
        }

        Console.Write(" "); // Clear the spinner
        Console.WriteLine(); 
    }
}