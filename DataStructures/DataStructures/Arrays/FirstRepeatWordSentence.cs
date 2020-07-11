using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public class FirstRepeatWordSentence
    {
//        Input : "Ravi had been saying that he had been there"
//Output : had

//Input : "Ravi had been saying that"
//Output : No Repetition

//Input : "he had had he"
//Output : he
        public FirstRepeatWordSentence()
        {
            Console.WriteLine("FirstRepeatWordSentence Input: Ravi had been saying that he had been there");
            
            Console.WriteLine("FirstRepeatWordSentence Ouput:" +FindWord("Ravi had been saying that he had been there"));

            Console.WriteLine("FirstRepeatWordSentence Input: Ravi had been saying that");

            Console.WriteLine("FirstRepeatWordSentence Ouput:" + FindWord("Ravi had been saying that"));

            Console.WriteLine("FirstRepeatWordSentence Input: he had had he");

            Console.WriteLine("FirstRepeatWordSentence Ouput:" + FindWord("he had had he"));
        }

        static string FindWord(string sentence)
        {
            var words = sentence.Split(" ");
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (keyValuePairs.ContainsKey(word))
                {
                    int currentCount;
                    if (keyValuePairs.TryGetValue(word, out currentCount))
                    {
                        keyValuePairs[word] = currentCount + 1;
                    }
                }
                else
                {
                    keyValuePairs.Add(word, 1);
                }
            }
            foreach (var k in keyValuePairs)
            {
                if(k.Value == 2)
                {
                    return k.Key;
                }
                else
                {
                    return "No Repetition";
                }
            }
            return null;
        }
    }
}
