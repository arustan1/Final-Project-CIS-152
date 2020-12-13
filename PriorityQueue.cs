using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Transactions;
using System.Xml;

namespace FinalProjectRustan
{
    /***************************************************************
    * Name        : PriorityQueue
    * Author      : Alicia Rustan
    * Created     : 12/08/2020
    ***************************************************************/
    class PriorityQueue
    {
        public Node head;
        public Node tail;

        public PriorityQueue()
        {
            this.head = null;
            this.tail = null;
        }

        public int FindPriority(string p)
        {
            p = p.ToUpper();
            if (p == "A")
            {
                return 1;
            }
            else if (p == "B")
            {
                return 2;
            }
            else if (p == "C")
            {
                return 3;
            }
            else if (p == "D")
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        public void Enqueue(string name, string priority)
        {
            Node current = head;
            Node previous = head;
            Node newNode = new Node(name, priority);
            if (this.tail == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                int currentPriority = FindPriority(current.priority);
                int p = FindPriority(priority);
                while (currentPriority <= p)
                {
                   
                    if (current.next == null)
                    {
                        current.next = newNode;
                        return;
                    }
                    else
                    {
                        previous = current;
                        current = current.next;
                        currentPriority = FindPriority(current.priority);

                    }
                }
                if (current == previous)
                {
                    this.head = newNode;
                    newNode.next = current;
                }
                else
                {
                    previous.next = newNode;
                    newNode.next = current;
                    return;
                }
            }
        }

        public void Dequeue()
        {
            if (this.head == null)
            {
                return;
            }

            Node current = this.head;
            this.head = this.head.next;

            if (this.head == null)
            {
                this.tail = null;
            }
        }

        public string Peek()
        {
            if (head == null)
            {
                return "Queue is Empty";
            }
            return this.head.name;
        }

        public string Print()
        {
            string stackString = "";
            Node current = head;
            if (head == null)
            {
                return ("All patients have been helped. :)");
            }
            while (current != null)
            {
                stackString += "NAME: " + current.name + " PRIORITY: " + current.priority.ToUpper() + "\n";
                current = current.next;
            }
            return stackString;

        }
    }
}
