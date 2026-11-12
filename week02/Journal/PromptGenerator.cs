using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private readonly Random _random = new Random();
    private readonly List<string> _prompts = new List<string>
    {
        "What small moment made me smile today?",
        "What did I learn today that I want to remember?",
        "How did I help someone today, or how did someone help me?",
        "What challenge did I face today, and how did I respond?",
        "What am I grateful for today, and why?",
        "When did I feel close to God today?",
        "What is one small thing I want to do better tomorrow?"
    };

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}
