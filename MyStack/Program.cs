namespace MyStack;
class Program
{
    static void Main(string[] args)
    {
 
        MyQueue myq = new MyQueue();      
        Console.WriteLine("Queue Implementation");
        myq.Enqueue(56);
        myq.Enqueue(30);
        myq.Enqueue(70);
        myq.Enqueue(40);
        myq.Enqueue(45);
        Console.WriteLine("Queue Before Dequeue");
        myq.DisplayQueue();
        Console.WriteLine("\n");
        myq.Dequeue();
        Console.WriteLine("Queue After Dequeue");
        myq.DisplayQueue();
        Console.ReadLine();
    }
}

