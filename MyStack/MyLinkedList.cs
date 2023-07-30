using System;
namespace MyStack
{
    public class MyLinkedList
    {
        internal Node head;

        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)  // No Elements in Linked List
            {
                this.head = node;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = node;

            }
            Console.WriteLine($"New Node Added At the end of the list {data}");

        }
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)  // No Elements in Linked List
            {
                this.head = node;

            }
            else
            {
                node.next = head;
                head = node;
            }
            Console.WriteLine($"New Node Added At the start of the list {data}");

        }

        public void InsertAtPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            Node node = new Node(data);
            if (position == 1)
            {
                if (this.head == null)
                {
                    head = node;
                }

                else
                {
                    node.next = head;
                    head = node;
                }
            }

            else
            {
                int currPosition = 1;
                Node temp = head;
                Node prev = null;
                while (temp != null)
                {
                    if (currPosition == position)
                    {
                        prev.next = node;
                        node.next = temp;
                        return;
                    }

                    currPosition++;
                    prev = temp;
                    temp = temp.next;

                }
                Console.WriteLine("Out Of range");
                return;
            }
        }
        public void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List Already Empty");
            }
            else
            {
                head = head.next;

            }
        }
        public void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List Already Empty");
            }
            else
            {
                Node temp = head;
                Node prev = temp;
                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;

                }
                prev.next = null;

            }
        }
        public bool Find(int value)
        {
            if (this.head == null)
            {
                return false;
            }
            else
            {
                Node temp = head;

                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        return true;
                    }
                    temp = temp.next;
                }

                return false;
            }
        }

        public void DisplayList()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }
        }
    }
}

