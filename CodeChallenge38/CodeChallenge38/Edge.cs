using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeChallenge38
{
    public class Edge
    {
        public int Weight { get; set; }
        public Vertex Neighbor { get; set; }

        public Edge(Vertex neighbor, int weight)
        {
            Neighbor = neighbor;
            Weight = weight;
        }

        public Edge(Vertex neighbor)
        {
            Neighbor = neighbor;
        }

    }
}