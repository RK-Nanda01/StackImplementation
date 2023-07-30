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
        myq.DisplayQueue();
        Console.ReadLine();
    }
}

