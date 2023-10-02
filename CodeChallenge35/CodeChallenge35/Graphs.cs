using CodeChallenge35;
using System;
using System.Collections.Generic;

namespace CodeChallenge35
{
    public class Graphs
    {
        public List<GraphNode> ListNodes { get; } = new List<GraphNode>();

        public GraphNode AddVertex(string value)
        {
            GraphNode newGN = new GraphNode(value);
            ListNodes.Add(newGN);
            return newGN;
        }

        public void AddEdge(GraphNode node1, GraphNode node2, int weight)
        {
            node1.Edges.Add(new GraphNodeEdges(node1, node2, weight));
            node2.Edges.Add(new GraphNodeEdges(node1, node2, weight));
        }

        public void AddEdge(GraphNode node1, GraphNode node2)
        {
            GraphNodeEdges nodeEdge = new GraphNodeEdges(node1, node2);
            node1.Edges.Add(nodeEdge);
            node2.Edges.Add(nodeEdge);
        }

        public List<GraphNode> GetVertices()
        {
            return ListNodes;
        }

        public List<GraphNode> GetNeighbors(GraphNode node)
        {
            List<GraphNode> NeighborsNode = new List<GraphNode>();
            GraphNode selectedNode = ListNodes.Find(nodes => nodes == node);

            if (selectedNode != null)
            {
                foreach (GraphNodeEdges edge in selectedNode.Edges)
                {
                    NeighborsNode.Add(edge.Node2);
                }
            }

            return NeighborsNode;
        }

        public int Size()
        {
            return ListNodes.Count;
        }
    }
}