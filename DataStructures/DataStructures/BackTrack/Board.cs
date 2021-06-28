using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.BackTrack
{
    class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public String word = null;
        public TrieNode() { }
    }
    public class Board
    {

        private char[][] _board = null;
        List<String> _result = new List<String>();

        public Board()
        {

        }
        public IList<string> FindWords(char[][] board, string[] words)
        {
            // Step 1). Construct the Trie
            TrieNode root = new TrieNode();
            foreach (String word in words)
            {
                TrieNode node = root;

                foreach (char letter in word.ToCharArray())
                {
                    if (node.children.ContainsKey(letter))
                    {
                        node = node.children[letter];
                    }
                    else
                    {
                        TrieNode newNode = new TrieNode();
                        node.children.Add(letter, newNode);
                        node = newNode;
                    }
                }
                node.word = word;  // store words in Trie
            }

            this._board = board;
            // Step 2). Backtracking starting for each cell in the board
            for (int row = 0; row < board.Length; ++row)
            {
                for (int col = 0; col < board[row].Length; ++col)
                {
                    if (root.children.ContainsKey(board[row][col]))
                    {
                        backtracking(row, col, root);
                    }
                }
            }

            return this._result;
        }

        private void backtracking(int row, int col, TrieNode parent)
        {
            char letter = this._board[row][col];
            TrieNode currNode = parent.children[letter];

            // check if there is any match
            if (currNode.word != null)
            {
                this._result.Add(currNode.word);
                currNode.word = null;
            }

            // mark the current letter before the EXPLORATION
            this._board[row][col] = '#';

            // explore neighbor cells in around-clock directions: up, right, down, left
            int[] rowOffset = { -1, 0, 1, 0 };
            int[] colOffset = { 0, 1, 0, -1 };
            for (int i = 0; i < 4; ++i)
            {
                int newRow = row + rowOffset[i];
                int newCol = col + colOffset[i];
                if (newRow < 0 || newRow >= this._board.Length || newCol < 0
                    || newCol >= this._board[0].Length)
                {
                    continue;
                }
                if (currNode.children.ContainsKey(this._board[newRow][newCol]))
                {
                    backtracking(newRow, newCol, currNode);
                }
            }

            // End of EXPLORATION, restore the original letter in the board.
            this._board[row][col] = letter;

            // Optimization: incrementally remove the leaf nodes
            if (currNode.children.Count==0)
            {
                parent.children.Remove(letter);
            }
        }
    }
}
