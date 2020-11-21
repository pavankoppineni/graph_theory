using GraphTheory.TopologicalSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.Tests.TopologicalSort
{
    [TestClass]
    public class TopologicalSortV1Tests
    {
        [TestMethod]
        public void Given_Graph_When_TopologocalSort_Then_ShouldReturnTopologicalOrder()
        {
            //Given
            var graph = new Dictionary<int, IList<int>>
            {
                { 0, new List<int> { 3 } },
                { 1, new List<int> { 3 } },
                { 2, new List<int> { 0, 1 } },
                { 3, new List<int> { 7, 6 } },
                { 4, new List<int> { 0, 3, 5 } },
                { 5, new List<int> { 9, 10 } },
                { 6, new List<int> { 8 } },
                { 7, new List<int> { 8, 9 } },
                { 8, new List<int> { 11 } },
                { 9, new List<int> { 11, 12 } },
                { 10, new List<int> { 9 } },
                { 11, new List<int>() },
                { 12, new List<int>() }
            };
            var topologicalSort = new TopologicalSortV1();
            var expectedTopologicalSort = new List<int>();

            //When
            var actualTopologicalSort = topologicalSort.TopologicalSort(graph);

            //Then
            Assert.Fail();
        }
    }
}
