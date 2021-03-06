using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Algortihms
{
    //https://github.com/mission-peace/interview/blob/master/src/com/interview/recursion/NQueenProblem.java
    //https://www.youtube.com/watch?v=xouin83ebxE&t=1s&ab_channel=TusharRoy-CodingMadeSimple
    

    public class Position
    {
        public int Row;
        public int Column;
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
    public class NQueensProblem
    {
        public void NQueensProblem_main()
        {
            Position[] positions = SolveNQueen(4);
            foreach (var pos in positions)
            {
                Console.WriteLine(pos.Row + "," + pos.Column);
            }
            List<List<Position>> allPositions = SolveNQueenAllSolutions(4);
            foreach (var item in allPositions)
            {
                foreach (var pos in item)
                {
                    Console.WriteLine(pos.Row + "," + pos.Column);
                }
            }


        }

        public Position[] SolveNQueen(int n)
        {
            Position[] positions = new Position[n];
            if (SolveNQueenUtil(positions, n, 0))
            {
                return positions;
            }
            else
            {
                return null;
            }
        }

        public bool SolveNQueenUtil(Position[] positions, int n, int row)
        {
            if (row == n)
            {
                return true;
            }
            for (int col = 0; col < n; col++)
            {
                bool isSafe = true;
                for (int queen = 0; queen < row; queen++)
                {
                    if (positions[queen].Row == row || positions[queen].Column == col ||
                        positions[queen].Row + positions[queen].Column == row + col ||
                        positions[queen].Row - positions[queen].Column == row - col)
                    {
                        isSafe = false;
                        break;
                    }
                }

                if (isSafe)
                {
                    positions[row] = new Position(row, col);
                    if (SolveNQueenUtil(positions, n, row + 1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public List<List<Position>> SolveNQueenAllSolutions(int n)
        {
            List<List<Position>> results = new List<List<Position>>();
            Position[] positions = new Position[n];
            SolveNQueenUtilAllSOlutions(results, positions, n, 0);
            return results;
        }

        public void SolveNQueenUtilAllSOlutions(List<List<Position>> results, Position[] positions, int n, int row)
        {
            if (row == n)
            {
                List<Position> currentResult = new List<Position>();
                foreach (var position in positions)
                {
                    currentResult.Add(position);
                }
                results.Add(currentResult);
                return;
            }
            for (int col = 0; col < n; col++)
            {
                bool isSafe = true;
                for (int queen = 0; queen < row; queen++)
                {
                    if (positions[queen].Row == row || positions[queen].Column == col ||
                        positions[queen].Row + positions[queen].Column == row + col ||
                        positions[queen].Row - positions[queen].Column == row - col)
                    {
                        isSafe = false;
                        break;
                    }
                }

                if (isSafe)
                {
                    positions[row] = new Position(row, col);
                    SolveNQueenUtilAllSOlutions(results, positions, n, row + 1);
                }
            }
        }
    }
}