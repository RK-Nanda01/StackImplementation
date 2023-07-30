namespace MyStack;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stack Implementation");
        LinkedListStack myStack = new LinkedListStack();
        myStack.Push(70);
        myStack.Push(30);
        myStack.Push(56);
        myStack.DisplayStack();
        Console.ReadLine();
    }
}

