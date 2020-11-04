using GraphTheory.BreadthFirstSearchTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.Tests.BreadthFirstSearchTraversal
{
    [TestClass]
    public class BreadthFirstSearchTraversalV1Tests
    {
        [TestMethod]
        public void Given_Graph_When_BreadthFirstSearchTraversal_Then_ShouldTraverseAllNodesInGraph()
        {
            //Given
            var graph = new Graph(6);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);

            graph.AddEdge(1, 0);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);

            graph.AddEdge(2, 0);
            graph.AddEdge(2, 1);
            graph.AddEdge(2, 5);

            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);

            graph.AddEdge(4, 3);

            graph.AddEdge(5, 2);

            var breadthFirstSearch = new BreadthFirstSearchTraversalV1();
            var expectedResult = new List<int>(6)
            {
                0,
                1,
                2,
                3,
                5,
                4
            };

            //When
            var actualResult = breadthFirstSearch.Traverse(graph);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
            for (var i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
