


var countOfQueries = int.Parse(Console.ReadLine());
var stack = new Stack<int>();
while (countOfQueries != 0)
{
    var queries = Console.ReadLine().Split().Select(int.Parse).ToArray();
    var first = queries[0];

    if (first == 1)
    {
        var elToPush = queries[1];
        stack.Push(elToPush);
    }
    else if(first == 2)
    {
        stack.Pop();
    }
    else if(first == 3)
    {
        if(stack.Count != 0)
        {
            Console.WriteLine(findMaxElement(stack));
        }
    }
    else
    {
        if(stack.Count != 0)
            Console.WriteLine(findMinElement(stack));

    }
    countOfQueries--;

}
if(stack.Count > 0)
{
    Console.WriteLine(string.Join(", ",stack));
}
Console.ReadKey();

static int findMaxElement(Stack<int> stack)
{
    var maxEl = stack.Peek();

    foreach (var item in stack)
    {
        if (item > maxEl)
            maxEl = item;
    }
    return maxEl;
}

static int findMinElement(Stack<int> stack)
{
    var minEl = stack.Peek();

    foreach (var item in stack)
    {
        if (item < minEl)
            minEl = item;
    }
    return minEl;
}

