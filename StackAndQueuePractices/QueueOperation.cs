using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuePractices
{
    public class QueueOperation
    {
        Node Front;
        Node Rear;
        public QueueOperation()
        {
            this.Front = null;
            this.Rear = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if(this.Rear == null)
            {
                this.Front = this.Rear;
                this.Rear = node;
            }
            else
            {
                this.Rear.next= node;
                this.Rear= node;
            }
            Console.WriteLine("{0} node added to the queue",data);
        }
        public void Dequeue()
        {
            if (this.Front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.Front;
            this.Front = this.Front.next;
            if(this.Front== null)
            {
                this.Rear = null;
            }
            Console.WriteLine("{0} node is removed from Queue",temp.data);
        }
        public void Display()
        {
            Node temp = this.Rear;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Queue Data: "+temp.data);
                temp = temp.next;
            }
        }
    }
}
