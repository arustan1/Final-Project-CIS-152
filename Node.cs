using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace FinalProjectRustan
{
    /***************************************************************
    * Name        : Node
    * Author      : Alicia Rustan
    * Created     : 12/08/2020
    ***************************************************************/
    class Node
    {
        public string name;
        public string priority;
        public Node next;
        public Node prev;

        public Node()
        {
            name = "";
            priority = "D";
            next = null;
        }

        public Node(string n, string p)
        {
            name = n;
            priority = p;
            next = null;
        }
    }
}
