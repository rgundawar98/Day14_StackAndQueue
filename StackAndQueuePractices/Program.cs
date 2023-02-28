using System;

namespace StackAndQueuePractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataStructures Stack and Queue Practices");
            Console.WriteLine("1.Create a stack\n2.Peek() And Pop() Methods\n3.Enqueue Operation");
            Console.WriteLine("Choose above option");
            int option = Convert.ToInt32(Console.ReadLine());  
            StackOperation operation = new StackOperation();
            QueueOperation queueOperation = new QueueOperation();
            switch (option)
            {
                case 1:
                    operation.push(70);
                    operation.push(30);
                    operation.push(56);
                    break;
                case 2:
                    operation.push(70);
                    operation.push(30);
                    operation.push(56);
                    Console.WriteLine("Displaying the stack element:");
                    operation.Display();
                    operation.Peek();
                    operation.Pop();
                    break;
                case 3:
                    queueOperation.Enqueue(70);
                    queueOperation.Enqueue(30);
                    queueOperation.Enqueue(56);
                    queueOperation.Display();
                    break;
            }
        }
    }
}
