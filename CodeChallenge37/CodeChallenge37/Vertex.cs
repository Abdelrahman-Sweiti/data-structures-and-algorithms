using CodeChallenge37;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge37
{
    public class Vertex
    {
        public Object Value { get; set; }
        public List<Edge> Edge { get; set; } = new List<Edge>();
        public bool Visited { get; set; }

        public Vertex(Object value)
        {
            Value = value;
            Visited = false;
        }

    }
}