using System;
using System.Collections.Generic;
using System.IO;


//prompt generator class
public class PromptGenerator {
    private static string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What are the things i can do to improve my relationship with God?"
    };

    private static int _PromptIndex = 0;
    public static string GetAnotherPrompt() {
        string prompt = _prompts[_PromptIndex];
        _PromptIndex = (_PromptIndex + 1) % _prompts.Length;
        return prompt;
    }
}