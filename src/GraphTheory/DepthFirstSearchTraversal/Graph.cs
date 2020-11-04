using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GraphTheory.BreadthFirstSearchTraversal
{
    public class Graph : IEnumerable<LinkedList<int>>
    {
        private readonly IList<LinkedList<int>> adjacencyList;

        public Graph(int numberOfNodes)
        {
            adjacencyList = new LinkedList<int>[numberOfNodes];
            for (var i = 0; i < numberOfNodes; i++)
            {
                adjacencyList[i] = new LinkedList<int>();
            }
        }

        public LinkedList<int> this[int index]
        {
            get
            {
                return adjacencyList[index];
            }
        }

        public void AddEdge(int u, int v)
        {
            adjacencyList[u].AddLast(v);
        }

        public IEnumerator<LinkedList<int>> GetEnumerator()
        {
            return adjacencyList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return adjacencyList.GetEnumerator();
        }

        public int Length
        {
            get
            {
                return adjacencyList.Count;
            }
        }
    }
}
