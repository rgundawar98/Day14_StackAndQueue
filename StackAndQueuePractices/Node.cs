using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuePractices
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)  //Created a constructor
        {
            this.data = data;
            this.next = null;
        }
    }
}
