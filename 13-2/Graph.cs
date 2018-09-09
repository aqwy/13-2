using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2
{
    class Graph
    {
        private readonly int MAX_SIZE = 10;
        private Vertex[] vertexList;
        private int nVerts;
        public Graph()
        {
            vertexList = new Vertex[MAX_SIZE];
            nVerts = 0;
        }
    }
}
