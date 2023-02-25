using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuePractices
{
    public class StackOperation
    {
        private Node top;
        public StackOperation()
        {
            this.top = null;
        }
        public void push (int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed into the stack",value);
        }
    }
}
