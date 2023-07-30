using System;
namespace MyStack
{
	public class MyQueue
	{
		private Node front;
        private Node rear;
        public MyQueue()
		{
			this.front = null;
			this.rear = null;
		}

		public void Enqueue(int data)
		{
            Node node = new Node(data);
            if (this.front == null)  // No Elements in Linked List
            {
                node.next = null;
                front = node;
                rear = node;

            }
            else
            {
                node.next = null;
                rear.next = node;
                rear = node;

            }
            
            Console.WriteLine($"New Node Added {data}");
        }
        public void DisplayQueue()
        {
            Node temp = this.front;

            if (temp == null)
            {
                Console.WriteLine($"Queue Empty");
                return;
            }

            while (temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }

        }
    }
}

