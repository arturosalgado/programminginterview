using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInterview
{
    class Node
    {
        public int value;

        public Node(int value)
        {

            this.value = value; 

        }

        public override string ToString()
        {
            return ""+this.value;
        }
    }
}
