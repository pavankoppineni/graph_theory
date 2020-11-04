using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.BreadthFirstSearchTraversal
{
    /// <summary>
    /// https://www.youtube.com/watch?v=09_LlHjoEiY&t=1998s
    /// </summary>
    public class BreadthFirstSearchTraversalV1
    {
        private IList<int> nodes;
        private bool[] visited;
        private Graph graph;

        public IList<int> Traverse(Graph graph)
        {
            this.graph = graph;
            this.visited = new bool[graph.Length];
            this.nodes = new List<int>();

            var queue = new Queue<int>();
            queue.Enqueue(0);
            visited[0] = true;
            this.nodes.Add(0);
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                var edges = graph[currentNode];
                var currentEdge = edges.First;
                while (currentEdge != null)
                {
                    var node = currentEdge.Value;
                    // Case 1 : Node is visited
                    // Action : Do nothing
                    if (visited[node])
                    {
                        currentEdge = currentEdge.Next;
                        continue;
                    }
                    // Case 2 : Node is not visited
                    // Action : Mark node as visited and enqueue it
                    else
                    {
                        currentEdge = currentEdge.Next;
                        visited[node] = true;
                        nodes.Add(node);
                        queue.Enqueue(node);
                    }
                }
            }

            return nodes;
        }
    }
}
