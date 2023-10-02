using System;
using System.Collections.Generic;

namespace CodeChallenge35
{
    public class GraphNode
    {
        public string Value { get; set; }
        public List<GraphNodeEdges> Edges { get; } = new List<GraphNodeEdges>();

        public GraphNode(string val)
        {
            Value = val;
        }

        public GraphNode(string val, GraphNode node1, GraphNode node2)
        {
            Value = val;
            Edges.Add(new GraphNodeEdges(node1, node2));
        }
    }

    public class GraphNodeEdges
    {
        public GraphNode Node1 { get; set; }
        public GraphNode Node2 { get; set; }
        public int EdgeWeight { get; set; }

        public GraphNodeEdges(GraphNode node1, GraphNode node2)
        {
            Node1 = node1;
            Node2 = node2;
        }

        public GraphNodeEdges(GraphNode node1, GraphNode node2, int weight)
        {
            Node1 = node1;
            Node2 = node2;
            EdgeWeight = weight;
        }
    }
}