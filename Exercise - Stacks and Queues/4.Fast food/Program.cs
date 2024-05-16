

var foodQuantity = int.Parse(Console.ReadLine());

var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

var queue = new Queue<int>();
insertInTheQueue(queue, orders);
Console.WriteLine(findMax(queue));

for (int i = 0; i < orders.Length; i++)
{
    if (orders[i] <= foodQuantity)
    {
        queue.Dequeue();
        foodQuantity -= orders[i];
    } 
    else
        break;
}

if(queue.Count == 0)
    Console.WriteLine("Orders complete");
else
    Console.WriteLine($"Orders left: {string.Join(" ",queue)}");

Console.ReadKey();


static int findMax(Queue<int> queue)
{
    var maxEl = queue.Peek();
    foreach (var item in queue)
    {
        if (item > maxEl)
            maxEl = item;
    }
    return maxEl;
}

static void insertInTheQueue(Queue<int> queue, int[] orders)
{
    for (int i = 0; i < orders.Length; i++)
    {
        queue.Enqueue(orders[i]);
    }
}