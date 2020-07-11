using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public class SecondOccurenceValue
    {
        //Input : {"aaa", "bbb", "ccc", "bbb", 
        // "aaa", "aaa"}
        //Output : bbb

        //Input : {"geeks", "for", "geeks", "for",
        //          "geeks", "aaa"}
        //    Output : for
        public SecondOccurenceValue()
        {
            Console.WriteLine("\n Print SecondOccurenceValue First Input");
            foreach (var n in (new[] {"aaa", "bbb", "ccc", "bbb","aaa", "aaa"}))
            {
                Console.Write(n + " ");
            }


            Console.WriteLine("\n Print SecondOccurenceValue Sort"+ FindValue(new[] { "aaa", "bbb", "ccc", "bbb", "aaa", "aaa" }));
            
        }

        static string FindValue(string[] input)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            for(int i=0;i<input.Length;i++)
            {
                if(keyValuePairs.ContainsKey(input[i]))
                {
                    int currentCount;
                    if(keyValuePairs.TryGetValue(input[i], out currentCount))
                    {
                        keyValuePairs[input[i]] = currentCount + 1;
                    }
                }
                else
                {
                    keyValuePairs.Add(input[i], 1);
                }
            }
            int firstMax = 0;
            int secondMax = 0;
            foreach(var k in keyValuePairs)
            {
                if(k.Value > firstMax)
                {
                    firstMax = k.Value;
                }
                else if(k.Value > secondMax && k.Value!=firstMax)
                {
                    secondMax = k.Value;
                }
            }

            foreach (var k in keyValuePairs)
            {
                if (secondMax == k.Value)
                {
                    return k.Key;
                }
                
            }
            return null;
        }
    }
}
