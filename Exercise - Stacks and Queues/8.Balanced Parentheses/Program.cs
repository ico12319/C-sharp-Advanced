



var input = Console.ReadLine();
var queue = new Queue<char>();
addToQueue(input, queue);
var stack = new Stack<char>();
addToStack(input, stack);


if (areBalanced(queue,stack))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}




static void addToQueue(string input, Queue<char> queue)
{
    
    for (int i = 0; i < input.Length; i++)
    {
        queue.Enqueue(input[i]);
    }
}


static void addToStack(string input, Stack<char> stack)
{
    for (int i = 0; i < input.Length; i++)
    {
        stack.Push(input[i]);
    }
}

static bool areBalanced(Queue<char> queue,Stack<char> stack)
{
     while(queue.Count > 0)
    {
        var currStackEl = stack.Pop();
        var currQueueEl = queue.Dequeue();

        if(findOpposite(currQueueEl) != currStackEl)
        {
            return false;
        }
    }
    return true;
}





static char findOpposite(char symbol)
{
    if (symbol == '(')
    {
        return ')';
    }
    else if (symbol == '{')
    {
        return '}';
    }
    else if(symbol == '[')
    {
        return ']';
    }
    else if(symbol == ')')
    {
        return '(';
    }
    else if(symbol == '}')
    {
        return '{';
    }
    else if(symbol == ']')
    {
        return '[';
    }

    return '0';
}
