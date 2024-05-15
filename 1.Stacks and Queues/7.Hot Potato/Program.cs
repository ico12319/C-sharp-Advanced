using System;
using System.Collections.Generic;

class Program { 

    static void Main(string[] args)
    {
        var queue = new Queue<string>();
        var kids = Console.ReadLine().Split().ToList();
        addKids(kids, queue);

        var tossCount = int.Parse(Console.ReadLine());
        var count = 0;
        while (queue.Count != 1)
        {
            count++;
            var currKid = queue.Dequeue();
            if(count == tossCount)
            {
                Console.WriteLine($"Removed {currKid}");
                count = 0;
            }
            else
            {
                queue.Enqueue(currKid);
            }
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
        Console.ReadKey();


    }

    static void addKids(List<string> kids,Queue<string> queue)
    {
        for (int i = 0; i < kids.Count; i++)
        {
            queue.Enqueue(kids[i]);
        }
    }


    

}