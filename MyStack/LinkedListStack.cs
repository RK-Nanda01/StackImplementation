using System;
namespace MyStack
{
	public class LinkedListStack
	{
		private Node top;
		public LinkedListStack()
		{
			this.top = null;
		}

		public void Push(int data)
		{
            Node node = new Node(data);
            if (this.top == null)  // No Elements in Linked List
            {
                node.next = null;

            }
            else
            {
                node.next = this.top;
                
            }
            this.top = node;
            Console.WriteLine($"New Node Added {data}");
        }
        public int Peek()
        {
            return this.top.data;
        }

        public void Pop()
        {
            

            if (this.top == null)
            {
                Console.WriteLine($"Stack Already Empty");
                return;
            }

            else
            {
                Console.WriteLine($"Element {top.data} popped ");
                top = top.next;
                return;

            }
        }

        public void DisplayStack()
        {
            Node temp = this.top;

            if(temp == null)
            {
                Console.WriteLine($"Stack Empty");
                return;
            }

            while(temp!=null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }

        }
	}
}

