using GraphTheory.BreadthFirstSearchTraversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.DepthFirstSearchTraversal
{
    public class DepthFirstSearchTraversalV2
    {
        private Graph graph;
        private bool[] visited;
        private IList<int> nodes;

        public DepthFirstSearchTraversalV2(Graph graph)
        {
            this.graph = graph;
            this.visited = new bool[graph.Length];
            this.nodes = new List<int>();
        }

        public IList<int> Traverse(int nodeIndex)
        {
            if (!visited[nodeIndex])
            {
                nodes.Add(nodeIndex);
                visited[nodeIndex] = true;
                var edges = graph[nodeIndex];
                var currentEdge = edges.First;
                while (currentEdge != null)
                {
                    Traverse(currentEdge.Value);
                    currentEdge = currentEdge.Next;
                }
            }

            return nodes;
        }
    }
}
