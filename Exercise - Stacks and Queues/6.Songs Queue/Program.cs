


var songs = Console.ReadLine().Split(", ").ToList();
var queue = new Queue<string>();
addToQueue(queue, songs);

while (true)
{
    var cmd = Console.ReadLine().Split();
    var first = cmd[0];

    if(first == "Play")
    {
        queue.Dequeue();

        if(queue.Count == 0)
        {
            Console.WriteLine("No more songs!");
            break;
        }
    }
    else if(first == "Add")
    {
        var songName = string.Join(" ", cmd.Skip(1));
        if (queue.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained");
        }
        else
        {
            queue.Enqueue(songName);
        }
    }
    else if(first == "Show")
    {
        Console.WriteLine(string.Join(", ",queue));
    }
}


Console.ReadKey();







static void addToQueue(Queue<string> songs,List<string> input)
{
    for (int i = 0; i < input.Count; i++)
    {
        songs.Enqueue(input[i]);
    }
}