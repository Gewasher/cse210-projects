using System;

    public class PromptGenerator
    {
        public List<string> _prompts = new List<string>();




        public string GetRandomPrompt()
        {
            int num = _prompts.Count();

            Random randomGenerator= new Random ();
            int var = randomGenerator.Next(0, num);

            string rprompt = _prompts[var];
            
            return($"{rprompt}");
        }
    }
