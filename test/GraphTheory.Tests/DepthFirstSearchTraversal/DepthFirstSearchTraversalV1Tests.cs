using GraphTheory.BreadthFirstSearchTraversal;
using GraphTheory.DepthFirstSearchTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.Tests.DepthFirstSearchTraversal
{
    [TestClass]
    public class DepthFirstSearchTraversalV1Tests
    {
        [TestMethod]
        public void Given_Graph_When_DepthFirstSearchTraversal_Then_ShoulVisitAllTheNodes()
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

            var depthFirstTraversal = new DepthFirstSearchTraversalV1();
            var expectedResult = new List<int>(6)
            {
                0,
                1,
                2,
                5,
                3,
                4
            };

            //When
            var actualResult = depthFirstTraversal.Traverse(graph);

            //Then
            Assert.AreEqual(expectedResult.Count, actualResult.Count);
            for(var i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
