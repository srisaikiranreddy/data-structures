﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees.Amazon
{
    public class WordLadderII
    {
        public WordLadderII()
        {
            FindLadders("hit","cog",new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });
        }

        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<string, HashSet<string>> graph = new Dictionary<string, HashSet<string>>();
            AddWordToGraph(beginWord, graph);
            foreach (var word in wordList)
                AddWordToGraph(word, graph);

            //Queue For BFS
            Queue<string> queue = new Queue<string>();
            //Dictionary to store shortest paths to a word
            Dictionary<string, IList<IList<string>>> paths = new Dictionary<string, IList<IList<string>>>();

            queue.Enqueue(beginWord);
            paths[beginWord] = new List<IList<string>>() { new List<string>() { beginWord } };

            HashSet<string> visited = new HashSet<string>();

            while (queue.Count > 0)
            {

                var stopWord = queue.Dequeue();
                //we can terminate loop once we reached the endWord as all paths leads here already                 visited in previous level 
                if (stopWord.Equals(endWord))
                {
                    return paths[endWord];
                }
                else
                {
                    if (visited.Contains(stopWord))
                        continue;
                    visited.Add(stopWord);

                    //Transform word to intermidiate words and find matches
                    for (int i = 0; i < stopWord.Length; i++)
                    {
                        StringBuilder sb = new StringBuilder(stopWord);
                        sb[i] = '*';
                        var transform = sb.ToString();

                        if (graph.ContainsKey(transform))
                        {
                            //Iterating all adj words
                            foreach (var word in graph[transform])
                            {
                                if (!visited.Contains(word))
                                {
                                    //fetch all paths leads current word to generate paths to adj/child node 
                                    foreach (var path in paths[stopWord])
                                    {
                                        var newPath = new List<string>(path);
                                        newPath.Add(word);

                                        if (!paths.ContainsKey(word))
                                            paths[word] = new List<IList<string>>() { newPath };
                                        else if (paths[word][0].Count >= newPath.Count)// we are interested in shortest paths only
                                            paths[word].Add(newPath);
                                    }
                                    queue.Enqueue(word);
                                }
                            }
                        }
                    }
                }
            }
            return new List<IList<string>>();
        }


        private void AddWordToGraph(string word, Dictionary<string, HashSet<string>> graph)
        {

            for (int i = 0; i < word.Length; i++)
            {

                StringBuilder sb = new StringBuilder(word);
                sb[i] = '*';

                if (graph.ContainsKey(sb.ToString()))
                    graph[sb.ToString()].Add(word);
                else
                {
                    var set = new HashSet<string>();
                    set.Add(word);
                    graph[sb.ToString()] = set;
                }

            }

        }
    }
}
