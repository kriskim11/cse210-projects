using System;
using System.Collections.Generic;

public class PromptGen
{   // list of prompts
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "What was the most challenging part of my day?",
        "What is something new I learned today?",
        "What am I grateful for today?",
        "How did I make a positive impact on someone today?",
        "What is a goal I have for tomorrow?"
    };
    // returns a random prompt from list 
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}