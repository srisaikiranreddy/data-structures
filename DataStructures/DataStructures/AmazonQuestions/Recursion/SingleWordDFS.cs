using System;
namespace DataStructures.AmazonQuestions.Recursion
{
    public class SingleWordDFS
    {
        private char[][] board;
        private int ROWS;
        private int COLS;

        public SingleWordDFS()
        {
            char[][] jaggedArray2 = new char[][]
            {
                new char[] { 'A','B','C','E', },
                new char[] { 'S','F','C','S',},
                new char[] { 'A','D','E','E', }                
            };
            Exist(jaggedArray2, "ABCCED");
        }

        public bool Exist(char[][] board, String word)
        {
            this.board = board;
            this.ROWS = board.Length;
            this.COLS = board[0].Length;

            for (int row = 0; row < this.ROWS; ++row)
                for (int col = 0; col < this.COLS; ++col)
                    if (this.backtrack(row, col, word, 0))
                        return true;
            return false;
        }

        protected bool backtrack(int row, int col, String word, int index)
        {
            /* Step 1). check the bottom case. */
            if (index >= word.Length)
                return true;

            /* Step 2). Check the boundaries. */
            if (row < 0 || row == this.ROWS || col < 0 || col == this.COLS
                || this.board[row][col] != word[index])
                return false;

            /* Step 3). explore the neighbors in DFS */
            bool ret = false;
            // mark the path before the next exploration
            this.board[row][col] = '#';

            int[] rowOffsets = { 0, 1, 0, -1 };
            int[] colOffsets = { 1, 0, -1, 0 };
            for (int d = 0; d < 4; ++d)
            {
                ret = this.backtrack(row + rowOffsets[d], col + colOffsets[d], word, index + 1);
                if (ret)
                    break;
            }

            /* Step 4). clean up and return the result. */
            this.board[row][col] = word[index];
            return ret;
        }
    }
}
