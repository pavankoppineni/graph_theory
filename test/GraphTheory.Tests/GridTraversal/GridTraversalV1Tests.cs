using GraphTheory.GridTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.Tests.GridTraversal
{
    [TestClass]
    public class GridTraversalV1Tests
    {
        [TestMethod]
        public void Given_Grid_When_Traverse_Then_ShouldTraverseAllCellsInGrid()
        {
            //Given
            var grid = new int[2, 2]
            {
                {1, 2 },
                {4, 5 }
            };
            var gridTraversal = new GridTraversalV1();
            var expectedResult = new bool[1, 1];

            //When
            var actualResult = gridTraversal.Traverse(grid);

            //Then
            Assert.Inconclusive();
        }
    }
}
