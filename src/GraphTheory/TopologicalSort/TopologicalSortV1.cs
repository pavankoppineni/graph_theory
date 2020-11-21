using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GraphTheory.TopologicalSort
{
    /// <summary>
    /// https://youtu.be/09_LlHjoEiY?t=3394
    /// </summary>
    public class TopologicalSortV1
    {
        private int numberOfNodes;
        private bool[] visitedNodes;
        private int[] topologicalOrder;
        private IDictionary<int, IList<int>> graph;
        private int topologicalOrderIndex;

        public int[] TopologicalSort(IDictionary<int, IList<int>> graph)
        {
            this.graph = graph;
            numberOfNodes = graph.Count;
            visitedNodes = new bool[numberOfNodes];
            topologicalOrder = new int[numberOfNodes];
            topologicalOrderIndex = numberOfNodes - 1;

            for (var node = 0; node < numberOfNodes; node++)
            {
                if (visitedNodes[node])
                {
                    continue;
                }
                DepthFirstSearch(node);
            }

            return topologicalOrder;
        }

        private void DepthFirstSearch(int node)
        {
            visitedNodes[node] = true;
            var numberOfEdges = graph[node];
            foreach (var edge in numberOfEdges)
            {
                if (visitedNodes[edge])
                {
                    continue;
                }
                DepthFirstSearch(edge);
            }
            topologicalOrder[topologicalOrderIndex] = node;
            topologicalOrderIndex -= 1;
        }
    }
}
