


var input = Console.ReadLine().Split().Select(int.Parse).ToList();

var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


var elementsToPush = input[0];
var elementsToPop = input[1];
var elementToSearch = input[2];

var stack = new Stack<int>();

insertElements(stack, numbers, elementsToPush);

popElements(stack, numbers, elementsToPop);

if (searchElement(stack, elementToSearch))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(findSmallest(stack));
}
Console.ReadKey();



static void readInput(List<int> input)
{
    input = Console.ReadLine().Split().Select(int.Parse).ToList();
}

static void insertElements(Stack<int> stack,List<int> nums,int elementsToPush)
{
    for (int i = 0; i < elementsToPush; i++)
    {
        stack.Push(nums[i]);
    }
}

static void popElements(Stack<int> stack,List<int> nums,int elementsToPop)
{
    for (int i = 0; i < elementsToPop; i++)
    {
        if (stack.Count == 0)
        {
            break;
        }

        stack.Pop();
    }
}


static bool searchElement(Stack<int> stack,int element)
{
    foreach (var item in stack)
    {
        if (item == element)
            return true;
    }
    return false;
}


static int findSmallest(Stack<int> stack)
{
    if(stack.Count == 0)
    {
        return 0;
    }

    var smallest = stack.Pop();

    while (stack.Count > 0)
    {
        var currElement = stack.Pop();
        if(currElement < smallest)
        {
            smallest = currElement;
        }
    }
    return smallest;
}