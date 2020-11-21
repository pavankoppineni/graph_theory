using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.GridTraversal
{
    public class GridTraversalV1
    {
        private int[] row_vector = new int[] { -1, 0, 1, 0 };
        private int[] column_vector = new int[] { 0, 1, 0, -1 };
        private bool[,] visited;
        private Queue<(int row, int column)> queue;
        private int rows;
        private int columns;

        public bool[,] Traverse(int[,] grid)
        {
            rows = grid.GetLength(0);
            columns = grid.GetLength(1);
            queue = new Queue<(int row, int column)>();
            visited = new bool[rows, columns];

            var currentRow = 0;
            var currentColumn = 0;
            queue.Enqueue((row : currentRow, column : currentColumn));
            visited[0, 0] = true;
            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();
                currentRow = currentCell.row;
                currentColumn = currentCell.column;
                
                for (var i = 0; i < row_vector.Length; i++)
                {
                    var nextRowIndex = currentRow + row_vector[i];
                    var nextColumnIndex = currentColumn + column_vector[i];

                    //Case 1 : next row index is less than 0
                    //Action : Do nothing
                    if (nextRowIndex < 0)
                    {
                        continue;
                    }

                    //Case 2 : next row index is greater than or equal to number of rows in grid
                    //Action : Do nothing
                    if (nextRowIndex >= rows)
                    {
                        continue;
                    }

                    //Case 3 : next column is less than 0
                    //Action : Do nothing
                    if (nextColumnIndex < 0)
                    {
                        continue;
                    }

                    //Case 4 : Next column index is greater than or equal to number of columns in grid
                    //Action : Do nothing
                    if (nextColumnIndex >= columns)
                    {
                        continue;
                    }

                    //Case 5 : If cell in grid is visited
                    //Action : Do nothing
                    if(visited[nextRowIndex, nextColumnIndex] == true)
                    {
                        continue;
                    }

                    visited[nextRowIndex, nextColumnIndex] = true;

                    queue.Enqueue((row : nextRowIndex, column : nextColumnIndex));
                }
            }

            return visited;
        }
    }
}
