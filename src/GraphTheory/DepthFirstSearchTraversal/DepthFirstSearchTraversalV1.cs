using GraphTheory.BreadthFirstSearchTraversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.DepthFirstSearchTraversal
{
    public class DepthFirstSearchTraversalV1
    {
        private bool[] visited;
        private IList<int> nodes;
        private Graph graph;

        public IList<int> Traverse(Graph graph)
        {
            this.nodes = new List<int>();
            this.graph = graph;
            this.visited = new bool[this.graph.Length];
            Traverse(0);
            return nodes;
        }

        private void Traverse(int nodeIndex)
        {
            // Case 1 : Node is visited before
            // Action : Do nothing
            if (visited[nodeIndex] == true)
            {
                return;
            }
            // Case 2 : Node is not visited
            // Action : Set to true in visited array
            else
            {
                nodes.Add(nodeIndex);
                visited[nodeIndex] = true;
                var edgeList = graph[nodeIndex];
                var currentEdge = edgeList.First;
                while (currentEdge != null)
                {
                    Traverse(currentEdge.Value);
                    currentEdge = currentEdge.Next;
                }
            }
        }
    }
}
