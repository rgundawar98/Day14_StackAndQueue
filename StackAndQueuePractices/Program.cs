using System;

namespace StackAndQueuePractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the DataStructures Stack and Queue Practices");
            Console.WriteLine("1.Create a stack");
            Console.WriteLine("Choose above option");
            int option = Convert.ToInt32(Console.ReadLine());  
            switch (option)
            {
                case 1:
                    StackOperation operation = new StackOperation();
                    operation.push(70);
                    operation.push(30);
                    operation.push(56);
                    operation.Display();
                    break;
            }
        }
    }
}
