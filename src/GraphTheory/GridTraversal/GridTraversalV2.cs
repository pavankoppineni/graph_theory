namespace GraphTheory.GridTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GridTraversalV2
    {
        private int rowCount;
        private int columnCount;
        private Queue<(int rowIndex, int columnIndex)> queue;
        private bool[,] visitedCells;

        // Vector direction
        // [Nort, East, South, West]
        private int[] rowVector = new int[] { -1, 0, 1, 0 };
        private int[] columnVector = new int[] { 0, 1, 0, -1 };

        public (int rowIndex, int columnIndex) FindPath(char[,] maze)
        {
            rowCount = maze.GetLength(0);
            columnCount = maze.GetLength(1);
            visitedCells = new bool[rowCount, columnCount];
            queue = new Queue<(int rowIndex, int columnIndex)>();
            visitedCells[0, 0] = true;
            queue.Enqueue((0, 0));
            (int rowIndex, int columnIndex) result = (-1, -1);
            var exitFound = false;
            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();
                var currentRow = currentCell.rowIndex;
                var currentColumn = currentCell.columnIndex;

                for (var vectorIndex = 0; vectorIndex < rowVector.Length; vectorIndex++)
                {
                    var currentRowVector = currentRow + rowVector[vectorIndex];
                    var currentColumnVector = currentColumn + columnVector[vectorIndex];

                    if (currentRowVector < 0 || currentRowVector >= rowCount)
                    {
                        continue;
                    }

                    if (currentColumnVector < 0 || currentColumnVector >= columnCount)
                    {
                        continue;
                    }

                    if (maze[currentRowVector, currentColumnVector] == '#')
                    {
                        continue;
                    }

                    if (visitedCells[currentRowVector, currentColumnVector])
                    {
                        continue;
                    }

                    if (maze[currentRowVector, currentColumnVector] == 'e')
                    {
                        result.rowIndex = currentRowVector;
                        result.columnIndex = currentColumnVector;
                        exitFound = true;
                        break;
                    }

                    visitedCells[currentRowVector, currentColumnVector] = true;
                    queue.Enqueue((currentRowVector, currentColumnVector));
                }

                if (exitFound)
                {
                    break;
                }
            }

            return result;
        }
    }
}
