using GraphTheory.GridTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.Tests.GridTraversal
{
    [TestClass]
    public class GridTraversalV2Tests
    {
        [TestMethod]
        public void Give_Maze_When_FindExit_Then_ShouldFindPathFromEntryToExitInMaze()
        {
            //Given
            var maze = new char[4, 4]
            {
                { 's', '.', '#', '#' },
                { '.', '.', '.', '.' },
                { '.', '#', '.', '.' },
                { '.', 'e', '.', '#' },
            };
            var expectedExitCellIndex = (rowIndex :  3, columnIndex : 1);
            var graphTraversalV2 = new GridTraversalV2();

            //When
            var actualExitCellIndex = graphTraversalV2.FindPath(maze);

            //Then
            Assert.AreEqual(expectedExitCellIndex, actualExitCellIndex);
       }
    }
}
