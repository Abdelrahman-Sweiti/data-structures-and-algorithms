using CodeChallenge38;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToGraph()
        {
            Graph graph = new Graph();

            Vertex node = (Vertex)graph.AddNode("A");

            Assert.Contains(node, graph.Vertices);
        }
        [Fact]
        public void EdgeCanBeAddedToGraph()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            Vertex C = (Vertex)graph.AddNode("C");

            graph.AddEdge(A, B, 15);

            Assert.NotEmpty(A.Edge);
        }
        [Fact]
        public void CanGetGraphNodeList()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            var list = graph.GetNodes();

            Assert.IsType<List<Vertex>>(list);
        }
        [Fact]
        public void CanGetNeighborsFromNode()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            Vertex C = (Vertex)graph.AddNode("C");
            graph.AddEdge(A, B, 45);
            graph.AddEdge(A, C, 9);

            var result = graph.GetNeighbors(A);

            Assert.Equal(2, result.Count);
        }
        [Fact]
        public void NieghborNodesHaveWeight()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            graph.AddEdge(A, B, 9999);

            Edge[] result = graph.GetNeighbors(A).ToArray();

            Assert.Equal(9999, result[0].Weight);
        }
        [Fact]
        public void CanGetSizeOfGraph()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            int count = graph.Size();

            Assert.Equal(7, count);
        }
        [Fact]
        public void GraphCanHaveOneNodeAndEdge()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            graph.AddEdge(A, A, 7);

            List<Vertex> result = graph.GetNodes();

            Assert.Equal(A, result.ToArray()[0]);
        }
        [Fact]
        public void EmptyGraphReturnsNull()
        {
            Graph graph = new Graph();

            var result = graph.GetNodes();

            Assert.Null(result);
        }
        [Fact]
        public void CanReturnRouteAtoG()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");

            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");

            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);
            graph.AddEdge(A, D, 6);
            graph.AddEdge(B, E, 10);
            graph.AddEdge(C, E, 80);
            graph.AddEdge(D, E, 74);

            List<Vertex> list = graph.BreadthFirst(A);
            object[] result = new object[5];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list[i].Value;
            }
            object[] expected = { "A", "B", "C", "D", "E" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void CanReturnSelfPointingEdge()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            Vertex A = new Vertex("A");
            graph.AddEdge(A, A, 1);

            List<Vertex> result = graph.BreadthFirst(A);

            Assert.Equal("A", result[0].Edge[0].Neighbor.Value);
        }
        [Fact]
        public void PathOfManyCitiesReturnsCost()
        {
            Graph graph2 = new Graph();
            graph2.AddNode("Irbid");
            graph2.AddNode("Amman");
            graph2.AddNode("Zarqa");
            graph2.AddNode("Aqaba");
            graph2.AddNode("Madaba");
            Vertex A2 = new Vertex("Irbid");
            Vertex B2 = new Vertex("Amman");
            Vertex C2 = new Vertex("Zarqa");
            Vertex D2 = new Vertex("Aqaba");
            Vertex E2 = new Vertex("Madaba");
            graph2.AddEdge(A2, B2, 180);
            graph2.AddEdge(A2, C2, 100);
            graph2.AddEdge(B2, C2, 75);
            graph2.AddEdge(C2, D2, 350);
            graph2.AddEdge(C2, E2, 250);
            graph2.AddEdge(D2, E2, 150);

            string[] cities = { "Irbid", "Amman", "Zarqa" };
            var result = graph2.BusinessTrip(graph2, cities);
            var expected = 255;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void NoDirectPathReturnsnull()
        {
            Graph graph2 = new Graph();
            graph2.AddNode("Irbid");
            graph2.AddNode("Amman");
            graph2.AddNode("Zarqa");
            graph2.AddNode("Aqaba");
            graph2.AddNode("Madaba");
            Vertex A2 = new Vertex("Irbid");
            Vertex B2 = new Vertex("Amman");
            Vertex C2 = new Vertex("Zarqa");
            Vertex D2 = new Vertex("Aqaba");
            Vertex E2 = new Vertex("Madaba");
            graph2.AddEdge(A2, B2, 180);
            graph2.AddEdge(A2, C2, 100);
            graph2.AddEdge(B2, C2, 75);
            graph2.AddEdge(C2, D2, 350);
            graph2.AddEdge(C2, E2, 250);
            graph2.AddEdge(D2, E2, 150);

            string[] cities = { "Irbid", "Aqaba" };
            var result = graph2.BusinessTrip(graph2, cities);

            Assert.Null(result);
        }
        [Fact]
        public void SingleCityArrayReturnsNull()
        {
            Graph graph2 = new Graph();
            graph2.AddNode("Irbid");
            graph2.AddNode("Amman");
            graph2.AddNode("Zarqa");
            graph2.AddNode("Aqaba");
            graph2.AddNode("Madaba");
            Vertex A2 = new Vertex("Irbid");
            Vertex B2 = new Vertex("Amman");
            Vertex C2 = new Vertex("Zarqa");
            Vertex D2 = new Vertex("Aqaba");
            Vertex E2 = new Vertex("Madaba");
            graph2.AddEdge(A2, B2, 180);
            graph2.AddEdge(A2, C2, 100);
            graph2.AddEdge(B2, C2, 75);
            graph2.AddEdge(C2, D2, 350);
            graph2.AddEdge(C2, E2, 250);
            graph2.AddEdge(D2, E2, 150);

            string[] cities = { "Irbid" };
            var result = graph2.BusinessTrip(graph2, cities);

            Assert.Null(result);
        }
        [Fact]
        public void DepthFirstGraphReturnsPreOrder()
        {
            Graph graph3 = new Graph();

            Vertex A3 = new Vertex("A");
            Vertex B3 = new Vertex("B");
            Vertex C3 = new Vertex("C");
            Vertex D3 = new Vertex("D");
            Vertex E3 = new Vertex("E");
            Vertex F3 = new Vertex("F");

            graph3.AddNode("A");
            graph3.AddNode("B");
            graph3.AddNode("C");
            graph3.AddNode("D");
            graph3.AddNode("E");
            graph3.AddNode("F");

            graph3.AddEdge(A3, B3, 4);
            graph3.AddEdge(A3, C3, 6);
            graph3.AddEdge(B3, D3, 22);
            graph3.AddEdge(B3, E3, 5);
            graph3.AddEdge(C3, F3, 15);

            Stack<Vertex> list = graph3.DepthFirst(graph3);
            Stack<object> result = new Stack<object>();
            foreach (Vertex node in list)
            {
                result.Push(node.Value);
            }
            Stack<object> expected = new Stack<object>();
            expected.Push("F");
            expected.Push("C");
            expected.Push("E");
            expected.Push("D");
            expected.Push("B");
            expected.Push("A");

            Assert.Equal(expected, result);

        }
        [Fact]
        public void SingleNodeDepthFirstGraphReturnsRoot()
        {
            Graph graph3 = new Graph();

            Vertex A3 = new Vertex("A");

            graph3.AddNode("A");

            Stack<Vertex> list = graph3.DepthFirst(graph3);
            Stack<object> result = new Stack<object>();
            foreach (Vertex node in list)
            {
                result.Push(node.Value);
            }
            Stack<object> expected = new Stack<object>();
            expected.Push("A");

            Assert.Equal(expected, result);
        }
        [Fact]
        public void EmptyDepthFirstGraphReturnsNull()
        {
            Graph graph = new Graph();

            Stack<Vertex> result = graph.DepthFirst(graph);

            Assert.Null(result);
        }
    }
}