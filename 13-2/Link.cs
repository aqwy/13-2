using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2
{
    class Link
    {
        public int iData;
        public Link next;
        public Link(int id)
        {
            iData = id;
        }
        public void display()
        {
            Console.Write(iData);
        }
    }
}
