using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //36. Valid Sudoku
    //https://leetcode.com/problems/valid-sudoku/

    public class ValidSudoku
    {
        //Using Hash Set
        //Time -O(n^2)
        //Space -O(n^2)
        public bool IsValidSudoku(char[][] board)
        {
            int N = 9;
            HashSet<char>[] row = new HashSet<char>[N];
            HashSet<char>[] col = new HashSet<char>[N];
            HashSet<char>[] box = new HashSet<char>[N];
            for (int i = 0; i < N; i++)
            {
                row[i] = new HashSet<char>();
                col[i] = new HashSet<char>();
                box[i] = new HashSet<char>();
            }

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    if (board[r][c] == '.')
                    {
                        continue;
                    }
                    char curr = board[r][c];
                    if (row[r].Contains(curr))
                    {
                        return false;
                    }
                    row[r].Add(curr);
                    if (col[c].Contains(curr))
                    {
                        return false;
                    }
                    col[c].Add(curr);
                    //box
                    int idx = (r / 3) * 3 + (c / 3);
                    if (box[idx].Contains(curr))
                    {
                        return false;
                    }
                    box[idx].Add(curr);
                }
            }
            return true;
        }

        //Using Arrays
        //Time -O(n^2)
        //Space -O(n^2)
        public bool IsValidSudoku1(char[][] board)
        {
            int N = 9;
            int[,] row = new int[N, N];
            int[,] col = new int[N, N];
            int[,] box = new int[N, N];

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    if (board[r][c] == '.')
                    {
                        continue;
                    }
                    int pos = board[r][c] - '1';
                    if (row[r, pos] == 1)
                    {
                        return false;
                    }
                    row[r, pos] = 1;
                    if (col[c, pos] == 1)
                    {
                        return false;
                    }
                    col[c, pos] = 1;

                    int idx = (r / 3) * 3 + (c / 3);
                    if (box[idx, pos] == 1)
                    {
                        return false;
                    }
                    box[idx, pos] = 1;
                }
            }
            return true;
        }

    }
}