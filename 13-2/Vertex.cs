using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2
{
    class Vertex
    {
        private bool wasVisited;
        private char lable;
        public Vertex(char lab)
        {
            lable = lab;
            wasVisited = false;
        }
    }
}
