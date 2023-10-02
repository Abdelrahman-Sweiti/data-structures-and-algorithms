using System;
using CodeChallenge35;
using CodeChallenge35;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddVertex()
        {
            // Arrange
            Graphs graph = new Graphs();

            // Act
            GraphNode nodeA = graph.AddVertex("A");

            // Assert
            Assert.NotNull(nodeA);
            Assert.Equal("A", nodeA.Value);
            Assert.Single(graph.ListNodes);
        }

        [Fact]
        public void TestAddEdge()
        {
            // Arrange
            Graphs graph = new Graphs();
            GraphNode nodeA = graph.AddVertex("A");
            GraphNode nodeB = graph.AddVertex("B");

            // Act
            graph.AddEdge(nodeA, nodeB, 5);

            // Assert
            Assert.Single(nodeA.Edges);
            Assert.Single(nodeB.Edges);
        }

        [Fact]
        public void TestGetVertices()
        {
            // Arrange
            Graphs graph = new Graphs();
            GraphNode nodeA = graph.AddVertex("A");
            GraphNode nodeB = graph.AddVertex("B");

            // Act
            var vertices = graph.GetVertices();

            // Assert
            Assert.Equal(2, vertices.Count);
            Assert.Contains(nodeA, vertices);
            Assert.Contains(nodeB, vertices);
        }

        [Fact]
        public void TestGetNeighbors()
        {
            // Arrange
            Graphs graph = new Graphs();
            GraphNode nodeA = graph.AddVertex("A");
            GraphNode nodeB = graph.AddVertex("B");
            graph.AddEdge(nodeA, nodeB, 5);

            // Act
            var neighbors = graph.GetNeighbors(nodeA);

            // Assert
            Assert.Single(neighbors);
            Assert.Equal(nodeB, neighbors[0]);
        }

        [Fact]
        public void TestGetNeighborsWithWeight()
        {
            // Arrange
            Graphs graph = new Graphs();
            GraphNode nodeA = graph.AddVertex("A");
            GraphNode nodeB = graph.AddVertex("B");
            graph.AddEdge(nodeA, nodeB, 5);

            // Act
            var edge = nodeA.Edges[0];

            // Assert
            Assert.Equal(5, edge.EdgeWeight);
        }

        [Fact]
        public void Test_Size_Success()
        {
            // Arrange
            Graphs graph = new Graphs();
            GraphNode nodeA = graph.AddVertex("A");
            GraphNode nodeB = graph.AddVertex("B");

            // Act
            var size = graph.Size();

            // Assert
            Assert.Equal(2, size);
        }

        [Fact]
        public void TestSingleVertexEdge()
        {
            // Arrange
            Graphs graph = new Graphs();
            GraphNode nodeA = graph.AddVertex("A");

            // Act
            var vertices = graph.GetVertices();
            var neighbors = graph.GetNeighbors(nodeA);

            // Assert
            Assert.Single(vertices);
            Assert.Empty(neighbors);
        }
    }
}