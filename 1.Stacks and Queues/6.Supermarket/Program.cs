using System;
using System.Collections.Generic;

class Program { 

    static void Main(string[] args)
    {
        var queue = new Queue<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if(input == "End")
            {
                break;
            }
            else if(input == "Paid")
            {
                while (queue.Count > 0)
                {
                    Console.WriteLine($"{queue.Dequeue()}");
                }
            }
            else
            {
                queue.Enqueue(input);
            }
        }
        Console.WriteLine($"{queue.Count} people remaining.");
        Console.ReadKey();

    }

    

}