using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.AmazonQuestions.Recursion
{
    //public class TrieNode
    //{
    //    public Hashtable children = new Hashtable();
    //    public string word = null;
    //    public TrieNode() { }
    //}

    //public class WordSearchDFS
    //{
    //    char[][] _board = null;
    //    List<string> _result = new List<string>();
    //    public WordSearchDFS()
    //    {
    //    }

    //    public IList<string> FindWords(char[][] board, string[] words)
    //    {
    //        TrieNode main = new TrieNode();

    //        foreach (string word in words)
    //        {
    //            TrieNode node = main;

    //            foreach (char alphabet in word)
    //            {
    //                if (node.children.ContainsKey(alphabet))
    //                {
    //                    node = node.children[alphabet];
    //                }
    //                else
    //                {
    //                    TrieNode newNode = new TrieNode();
    //                    node = node.children.Add();

    //                    node = newNode;
    //                }
    //            }
    //        }

    //        this._board = board;
    //        // Step 2). Backtracking starting for each cell in the board
    //        for (int row = 0; row < board.Length; ++row)
    //        {
    //            for (int col = 0; col < board[row].Length; ++col)
    //            {
    //                if (main.children.ContainsKey(board[row][col]))
    //                {
    //                    BackTracking(row, col, main);
    //                }
    //            }
    //        }

    //        return this._result;
    //    }

    //    private void BackTracking(int row, int col, TrieNode parent)
    //    {
    //        char letter = this._board[row][col];
    //        TrieNode currNode = parent.children.get(letter);

    //        // check if there is any match
    //        if (currNode.word != null)
    //        {
    //            this._result.add(currNode.word);
    //            currNode.word = null;
    //        }

    //        // mark the current letter before the EXPLORATION
    //        this._board[row][col] = '#';

    //        // explore neighbor cells in around-clock directions: up, right, down, left
    //        int[] rowOffset = { -1, 0, 1, 0 };
    //        int[] colOffset = { 0, 1, 0, -1 };
    //        for (int i = 0; i < 4; ++i)
    //        {
    //            int newRow = row + rowOffset[i];
    //            int newCol = col + colOffset[i];
    //            if (newRow < 0 || newRow >= this._board.Length || newCol < 0
    //                || newCol >= this._board[0].Length)
    //            {
    //                continue;
    //            }
    //            if (currNode.children.ContainsKey(this._board[newRow][newCol]))
    //            {
    //                BackTracking(newRow, newCol, currNode);
    //            }
    //        }

    //        // End of EXPLORATION, restore the original letter in the board.
    //        this._board[row][col] = letter;

    //        // Optimization: incrementally remove the leaf nodes
    //        if (currNode.children.isEmpty())
    //        {
    //            parent.children.remove(letter);
    //        }
    //    }
    //}
}
