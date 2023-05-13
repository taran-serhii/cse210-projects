public class PromptGenerator 
{
    // Member variable
    private List<string> _promptList;

    // Method for creating a list of prompts
    public PromptGenerator()
    {
        _promptList = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What I am grateful for today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What interesting insight did I find in Scriptures today?",
            "If I had one thing I could do over today, what would it be?",
            "What steps did I take today towards a goal I am working on?",
            "What is something that made me laugh or smile today?",
            "What is one thing I want to remember from today?",
        };
    }

    // Method to get random prompt from the list of prompts.
    public string GetRandomPrompt()
    {
        // Creating new instance of Random class and assigning it to a variable called random.
        Random random = new Random(); 
        // Generating a random integer from 0 to prompt count minus 1 in order to cover the full range of prompts from the list, 
        // and assigning this random integer to a variable called index.
        int index = random.Next(_promptList.Count);  
        return _promptList[index]; // Returning a prompt from the prompt list, which corresponds to a randomly selected index.
    }
}