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
        Console.WriteLine("Before Popping");
        myStack.DisplayStack();
        Console.WriteLine("\n");
        myStack.Pop();
        myStack.Peek();
        Console.WriteLine("After Popping");
        myStack.DisplayStack();
        Console.ReadLine();
    }
}

