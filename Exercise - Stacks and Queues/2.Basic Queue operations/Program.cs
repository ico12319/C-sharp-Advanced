


var input = Console.ReadLine().Split().Select(int.Parse).ToList();

var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


var elementsToEnqueue = input[0];
var elementsToDequeue = input[1];
var elementToSearch = input[2];

var queue = new Queue<int>();

insertElements(queue, numbers, elementsToEnqueue);

popElements(queue, numbers, elementsToDequeue);

if (searchElement(queue, elementToSearch))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(findSmallest(queue));
}
Console.ReadKey();


static void insertElements(Queue<int> queue,List<int> nums,int elementsToPush)
{
    for (int i = 0; i < elementsToPush; i++)
    {
        queue.Enqueue(nums[i]);
    }
}

static void popElements(Queue<int> queue,List<int> nums,int elementsToPop)
{
    for (int i = 0; i < elementsToPop; i++)
    {
        if (queue.Count == 0)
        {
            break;
        }

        queue.Dequeue();
    }
}


static bool searchElement(Queue<int> queue,int element)
{
    foreach (var item in queue)
    {
        if (item == element)
            return true;
    }
    return false;
}


static int findSmallest(Queue<int> queue)
{
    if(queue.Count == 0)
    {
        return 0;
    }

    var smallest = queue.Dequeue();

    while (queue.Count > 0)
    {
        var currElement = queue.Dequeue();
        if(currElement < smallest)
        {
            smallest = currElement;
        }
    }
    return smallest;
}